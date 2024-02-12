using System.Collections;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private float _volumeChangeSpeed = 0.003f;
    private float _targetVolume;

    private void Update()
    {
        StartCoroutine(ChangeVolume());
    }

    private IEnumerator ChangeVolume()
    {
        while (_audioSource.volume != _targetVolume)
        {
            float current = _audioSource.volume;
            float nextVolume = Mathf.MoveTowards(current, _targetVolume, _volumeChangeSpeed * Time.deltaTime);

            _audioSource.volume = nextVolume;
            yield return null;
        }
    }

    public void ActivateTrigger(float volume)
    {
        _targetVolume = volume;
    }
}

