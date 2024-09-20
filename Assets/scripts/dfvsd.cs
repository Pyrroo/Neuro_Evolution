using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolController : MonoBehaviour
{
    [SerializeField] private List<GameObject> preloadObjects = new();
    public static Dictionary<string, List<GameObject>> objectPoolList = new();
    private static GameObject tempGameobject;

    private static GameObject objectPoolGameObject;
    int i = 0;
    private void Awake()
    {
        objectPoolGameObject = gameObject;
        objectPoolList.Clear();
        for (i = 0; i < preloadObjects.Count; i++)
        {
            if (objectPoolList.ContainsKey(preloadObjects[i].name))
            {
                objectPoolList[preloadObjects[i].name].Add(preloadObjects[i]);
            }
            else
            {
                objectPoolList.Add(preloadObjects[i].name, new List<GameObject>() { preloadObjects[i] });
            }
        }
    }

    public static GameObject CreateGameObject(GameObject ObjectPref, Vector3 CreatePosition, Quaternion quaternion, Transform parent)
    {
        if (objectPoolList.ContainsKey(ObjectPref.name))
        {
            tempGameobject = objectPoolList[ObjectPref.name].Find(obj => !obj.activeSelf && obj != null);
            if (tempGameobject != null)
            {
                tempGameobject.transform.SetPositionAndRotation(CreatePosition, quaternion);
                tempGameobject.transform.parent = parent;
                tempGameobject.SetActive(true);
            }
            else
            {
                tempGameobject = Instantiate(ObjectPref, CreatePosition, quaternion, parent);
                objectPoolList[ObjectPref.name].Add(tempGameobject);
            }
        }
        else
        {
            tempGameobject = Instantiate(ObjectPref, CreatePosition, quaternion, parent);
            objectPoolList.Add(ObjectPref.name, new List<GameObject>() { tempGameobject });
        }
        return tempGameobject;
    }

    public static GameObject CreateGameObject(GameObject ObjectPref, Transform position, Vector3 localposition)
    {
        if (objectPoolList.ContainsKey(ObjectPref.name))
        {
            tempGameobject = objectPoolList[ObjectPref.name].Find(obj => !obj.activeSelf);
            if (tempGameobject != null)
            {
                tempGameobject.SetActive(true);
                tempGameobject.transform.localPosition = localposition;
            }
            else
            {
                tempGameobject = Instantiate(ObjectPref, position);
                objectPoolList[ObjectPref.name].Add(tempGameobject);
            }
        }
        else
        {
            tempGameobject = Instantiate(ObjectPref, position);
            objectPoolList.Add(ObjectPref.name, new List<GameObject>() { tempGameobject });
        }
        return tempGameobject;
    }

    public static void CreateVoidGameObject(GameObject ObjectPref, Vector3 CreatePosition, Quaternion quaternion, Transform parent)
    {
        if (objectPoolList.ContainsKey(ObjectPref.name))
        {
            tempGameobject = objectPoolList[ObjectPref.name].Find(obj => !obj.activeSelf);
            if (tempGameobject != null)
            {
                tempGameobject.transform.SetPositionAndRotation(CreatePosition, quaternion);
                tempGameobject.transform.parent = parent;
                tempGameobject.SetActive(true);
            }
            else
            {
                tempGameobject = Instantiate(ObjectPref, CreatePosition, quaternion, parent);
                objectPoolList[ObjectPref.name].Add(tempGameobject);
            }
        }
        else
        {
            tempGameobject = Instantiate(ObjectPref, CreatePosition, quaternion, parent);
            objectPoolList.Add(ObjectPref.name, new List<GameObject>() { tempGameobject });
        }
    }
    public static void ReturnGameObjectToPool(GameObject returnedGameObject)
    {
        if (returnedGameObject != null)
        {
            //returnedGameObject.transform.parent = objectPoolGameObject.transform;
            if (returnedGameObject.activeSelf)
                returnedGameObject.SetActive(false);
            returnedGameObject.transform.SetPositionAndRotation(objectPoolGameObject.transform.position, Quaternion.identity);
        }
    }

    public static void RemoveGameObjectFromPool(GameObject gameObjectToRemove, string gameObjectName)
    {
        objectPoolList[gameObjectName]?.Remove(gameObjectToRemove);
    }
}
