using UnityEngine;

public class SizeGrower : MonoBehaviour
{
    [SerializeField] private float _growthSpeed = 0.1f;

    private void Update()
    {
        transform.localScale += Vector3.one * _growthSpeed * Time.deltaTime;
    }
} //test