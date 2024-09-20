using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class Object_pool_manager : MonoBehaviour
{
    private static List<GameObject> objects = new();
    private static int UseblObjCount = 0;
    private static Queue<GameObject> queue = new Queue<GameObject>();




    private static void AddNewObject(GameObject obj)
    {
        
        objects.Add(obj);
        
    }
    public static GameObject TryToGetObject(GameObject obj, Transform position)
    {
        

        if (objects.Count == 0 || objects.Count == UseblObjCount)
        {
            Debug.Log("Создался новый объект");
            AddNewObject(obj);
            Instantiate(objects[objects.Count-1], position);
            objects[objects.Count - 1].SetActive(true);
            UseblObjCount++;
            queue.Enqueue(objects[objects.Count - 1]);
            return objects[objects.Count - 1];
        }
        else      
        {
            Debug.Log("Загрузился старый");
            queue.Enqueue(objects[UseblObjCount - 1]);
            UseblObjCount++;
            return objects[UseblObjCount - 1];
            
        }
    }
    public static void DestroyObject()
    {
        Debug.Log("Объект удалился");
        queue.Dequeue().SetActive(false);
        UseblObjCount--;
        
    }



}
