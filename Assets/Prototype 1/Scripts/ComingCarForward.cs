using UnityEngine;

public class ComingCarForward : MonoBehaviour
{
    public float speed = 20.0f;
    public GameObject armorCar;
    private bool _armorCarSpawned;
    private GameObject _spawnedArmorCar;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger") && !_armorCarSpawned)
        {
            _spawnedArmorCar = Instantiate(armorCar, new Vector3(0, 0, 182), Quaternion.Euler(0, 180, 0));
            _armorCarSpawned = true;
        }
        if (other.gameObject.CompareTag("DestroyTrigger"))
        {
            if (_spawnedArmorCar != null)
            {
                Destroy(_spawnedArmorCar);
                _armorCarSpawned = false;
            }
        }
    }
}