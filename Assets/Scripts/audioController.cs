using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class audioController : MonoBehaviour
{
        [SerializeField] private AudioClip lvlStart;
        [SerializeField] private AudioClip normalLoop;
        [SerializeField] private AudioClip scaredLoop;
        void Start()
        {
            StartCoroutine(playSound());
        }

        IEnumerator playSound()
        {
            GetComponent<AudioSource>().clip = lvlStart;
            GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(lvlStart.length);
            GetComponent<AudioSource>().clip = normalLoop;
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().loop = true;
        }
}
