using UnityEngine;

public class seguir_esfera : MonoBehaviour
{
    public Transform esfera;
    public Vector3 distancia;
    void Update()
    {
        transform.position = esfera.position+distancia;

    }
}
