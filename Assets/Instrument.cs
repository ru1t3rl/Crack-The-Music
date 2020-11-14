using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace CrackTheMusic.Audio
{
    public class Instrument : MonoBehaviour
    {
        [SerializeField] List<Note> notes;
        Note[] selectedNotes = new Note[8];

        public void AddSelectedNote(Note note, int position)
        {
            try
            {
                selectedNotes[position] = note;
            }
            catch (ArgumentOutOfRangeException)
            {
                Debug.Log($"<color=red><b>[Instrument]</b></color> Position {position} doesn't exist!");
            }
        }

        public void RemoveSelectedNote(int position)
        {
            try
            {
                selectedNotes[position] = null;
            }
            catch (ArgumentOutOfRangeException)
            {
                Debug.Log($"<color=red><b>[Instrument]</b></color> Position {position} doesn't exist!");
            }
        }

        public AudioClip getNodeAudio(eNote note)
        {
            for (int iNote = 0; iNote < notes.Count; iNote++)
            {
                if (notes[iNote].note == note)
                {
                    return notes[iNote].audio;
                }
            }

            return null;
        }
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
        G = 4,
        Kick = 7,
        HiHat = 8,
        Clav = 9
    }
}
