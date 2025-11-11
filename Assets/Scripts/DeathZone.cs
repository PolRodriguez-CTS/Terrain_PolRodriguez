using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerController _playerScript = other.gameObject.GetComponent<PlayerController>();
            _playerScript.Death();
        }
    }
}
