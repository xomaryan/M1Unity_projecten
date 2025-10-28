using UnityEngine;
using System.Collections.Generic;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private string currentSong = "";
    private float volume = 1.0f;
    private bool isPlaying = false;
    private bool isMuted = false;
    private int songsPlayed = 0;
    private List<string> songLibrary = new List<string> {
       "Minecraft OST - Sweden",
       "Halo Theme",
       "Zelda's Lullaby",
       "Celeste - First Steps",
       "Stardew Valley - Spring"
   };
    void Start()
    {
        PlayRandomSong();
        SetVolume(0.8f);
        Debug.Log("Current song: " + GetCurrentSong());
        Debug.Log("Is playing: " + IsPlaying());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlaySong("Minecraft OST - Sweden");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StopSong();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            SetVolume(0.5f);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            ToggleMute();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayRandomSong();
        }
    }
    public void PlaySong(string songName)
    {
        currentSong = songName;
        isPlaying = true;
        songsPlayed++;
        Debug.Log("Playing song: " + songName);
    }
    public void StopSong()
    {
        Debug.Log("Song stopped.");
        isPlaying = false;
    }
    public void SetVolume(float newVolume)
    {
        volume = newVolume;
        Debug.Log("Volume set to: " + volume);
    }
    public string GetCurrentSong()
    {
        return currentSong;
    }
    public bool IsPlaying()
    {
        return isPlaying;
    }
    public void PlayRandomSong()
    {
        int index = Random.Range(0, songLibrary.Count);
        PlaySong(songLibrary[index]);
    }
    public void ToggleMute()
    {
        isMuted = !isMuted;
        Debug.Log(isMuted ? "🔇 Muted" : "🔊 Unmuted");
    }
    public int GetSongsPlayedCount()
    {
        return songsPlayed;
    }
}
