using UnityEngine;

public class Door : MonoBehaviour
{
    private readonly int OpenTriger = Animator.StringToHash("Open");
    private readonly int CloseTriger = Animator.StringToHash("Close");

    [SerializeField] private Animator _animator;
    [SerializeField] private Alarm _alarm;

    private float _alarmOn = 1f;
    private float _alarmOff = 0f;

    public void Open()
    {
        _alarm.ActivateTrigger(_alarmOn);
        _animator.SetTrigger(OpenTriger);
    }

    public void Close()
    {
        _alarm.ActivateTrigger(_alarmOff);
        _animator.SetTrigger(CloseTriger);
    }
}
