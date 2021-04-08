using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// Class permettant d'instancier une nouvelle planète
/// </summary>
public class SpawnPlanet : MonoBehaviour
{

    [SerializeField] private GameObject planetPrefab;

    // Si l'utilisateur presse A alors on ajoute une planète.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        { 
            SpawnNewPlanet();  
        }
    }

    
    /// <summary>
    /// Permet d'instancier une nouvelle planète avec un matériau ayant certains paramètres aléatoires
    /// </summary>
    void SpawnNewPlanet()
    {
        planetPrefab = Instantiate(planetPrefab, transform.position, Quaternion.identity);
        var planetRenderer = planetPrefab.transform.GetComponent<Renderer>();
        var color1 = new Color(Random.Range(0f, 1f),Random.Range(0f, 1f),Random.Range(0f, 1f));
        var color2 = new Color(Random.Range(0f, 1f),Random.Range(0f, 1f),Random.Range(0f, 1f));
        planetRenderer.material.SetColor("_Color1", color1);
        planetRenderer.material.SetColor("_Color2", color2);
        planetRenderer.material.SetFloat("_ThresholdValue", Random.Range(0f,1f));
        planetRenderer.material.SetFloat("_ThresholdWidth", Random.Range(0f,1f));
    }
}
