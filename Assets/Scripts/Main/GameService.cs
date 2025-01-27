using System.Collections;
using System.Collections.Generic;
using ServiceLocator.Events;
using ServiceLocator.Map;
using ServiceLocator.Player;
using ServiceLocator.Sound;
using ServiceLocator.UI;
using ServiceLocator.Utilities;
using ServiceLocator.Wave;
using UnityEngine;

public class GameService : GenericMonoSingleton<GameService>
{
    public PlayerService playerService { get; private set; }
    public SoundService soundService { get; private set; }
    //private EventServiceManager eventServiceManager;
    public EventService eventService { get; private set; }
    public MapService mapService { get; private set; }
    public WaveService waveService { get; private set; }


    [SerializeField] private UIService uIService;
    public UIService UIService => uIService;


    [SerializeField] private PlayerScriptableObject playerScriptableObject;
    [SerializeField] private SoundScriptableObject soundScriptableObject;
    [SerializeField] private MapScriptableObject mapScriptableObject;
    [SerializeField] private WaveScriptableObject waveScriptableObject;

    [SerializeField] private AudioSource audioEffects;
    [SerializeField] private AudioSource backgroundMusic;

    //[SerializeField]private GameEventController<int> OnMapSelected { get; private set; }


    private void Start()
    {
        
        eventService = new EventService();

        
        playerService = new PlayerService(playerScriptableObject);
        soundService = new SoundService(soundScriptableObject, audioEffects, backgroundMusic);
        waveService = new WaveService(waveScriptableObject);
        mapService = new MapService(mapScriptableObject);
    }
    private void Update()
    {
        playerService.Update();
    }
}
