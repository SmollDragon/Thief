using UnityEngine;

public class DoorOpenTriger : MonoBehaviour
{
    [SerializeField] private Door _door;

    private bool _isOpened = false;
    private bool _hasOpener;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<DoorOpener>())
            _hasOpener = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<DoorOpener>())
            _hasOpener = false;
    }

    private void Update()
    {
        if (_isOpened == true && _hasOpener && Input.GetKeyDown(KeyCode.E))
        {          
            _door.Close();
            _isOpened = false;
        }

        if (_isOpened == false && _hasOpener && Input.GetKeyDown(KeyCode.E))
        {         
            _door.Open();
            _isOpened = true;
        }
    }
}
