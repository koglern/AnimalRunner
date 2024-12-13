using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject animalParent; // Parent-Objekt, z. B. Animal

    void Start()
    {
        ChooseAnimal();
        
    }

    private void ChooseAnimal()
    {
        if (animalParent != null && animalParent.transform.childCount > 0)
        {
            int randomIndex = Random.Range(0, animalParent.transform.childCount);
            
            // call random child
            Transform randomChild = animalParent.transform.GetChild(randomIndex);

            // deactivate all child objects
            foreach (Transform child in animalParent.transform)
            {
                child.gameObject.SetActive(false);
            }

            // activate a random child
            randomChild.gameObject.SetActive(true);

            Debug.Log("Activated Childobject: " + randomChild.name);
        }
        else
        {
            Debug.LogWarning("Animal Parent Object is empty or not assigned!");
        }
    }
}
