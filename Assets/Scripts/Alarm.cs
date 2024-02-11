using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private float _volumeChangeSpeed = 0.3f;
    private float _targetVolume;

    private void Update()
    {
        float current = _audioSource.volume;

        _audioSource.volume = Mathf.MoveTowards(current, _targetVolume, _volumeChangeSpeed * Time.deltaTime);    
    }

    public void ActivateTrigger(float volume)
    {
        if (volume > _audioSource.volume)
        {
            _targetVolume = volume;
        }
        else if (volume < _audioSource.volume)
        {
            _targetVolume = volume;
        }
    }
}

