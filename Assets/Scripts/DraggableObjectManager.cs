using UnityEngine;

public class DraggableObjectManager : MonoBehaviour
{
    public GameObject[] draggableItems;
    DraggableObject draggableObject;
    private void Start()
    { 
        
        foreach (GameObject gameobj in draggableItems) {
            if (gameobj.CompareTag("TypeBDropStrategy"))
            {
                draggableObject = gameobj.GetComponent<DraggableObject>();
                draggableObject.SetDropStrategy(new TypeBDropStrategy()); // Assign the TypeADropStrategy
            }
            else
            {
                draggableObject = gameobj.GetComponent<DraggableObject>();
                draggableObject.SetDropStrategy(new TypeADropStrategy()); // Assign the TypeBDropStrategy
            }
        }
    }
}
