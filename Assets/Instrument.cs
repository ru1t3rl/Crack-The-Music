using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackTheMusic.Audio
{
    public class Instrument : MonoBehaviour
    {
        [SerializeField] List<Note> notes;

    }

    [System.Serializable]
    public class Note
    {
        public eNote note;
        public AudioClip audio;
    }

    public enum eNote
    {
        A = 5,
        B = 6,
        C = 0,
        D = 1,
        E = 2,
        F = 3,
        G = 4
    }
}
