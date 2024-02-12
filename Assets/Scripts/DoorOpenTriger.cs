using UnityEngine;

public class DoorOpenTriger : MonoBehaviour
{
    [SerializeField] private Door _door;

    private bool _isOpened = false;
    private bool _hasOpener;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out DoorOpener doorOpener))
            _hasOpener = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out DoorOpener doorOpener))
            _hasOpener = false;
    }

    private void Update()
    {
        if (_isOpened == true && _hasOpener && Input.GetKeyDown(KeyCode.E))
        {
            _isOpened = false;
            _door.Close();
            
        }

        if (_isOpened == false && _hasOpener && Input.GetKeyDown(KeyCode.V))
        {
            _isOpened = true;
            _door.Open();
            
        }
    }
}
