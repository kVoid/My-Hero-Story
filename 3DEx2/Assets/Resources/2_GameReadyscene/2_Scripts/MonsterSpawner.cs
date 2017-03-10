using UnityEngine;
using System.Collections;

public class MonsterSpawner : MonoBehaviour {

    public Wave[] waves;
    public Monster2 monster;

    Wave currentWave;
    public static int currentWaveNumber;
    public static bool HeroWinBool;
    public static bool WaveStart;

    int MonsterRemainingToSpawn;
    int MonsterRemainingAlive;
    float nextSpawnTime;

    bool WaveOn;
    void Start()
    {
        WaveStart = false;
        WaveOn = true;
        HeroWinBool = false;
    }
    void Update()
    {
        if (MonsterRemainingToSpawn > 0 && Time.time > nextSpawnTime)
        {
            MonsterRemainingToSpawn--;
            nextSpawnTime = Time.time + currentWave.timeBetweenSpawns;

            Monster2 spawnedMonster = Instantiate(monster, Vector3.zero, Quaternion.identity) as Monster2;
            spawnedMonster.OnDeath += OnMonsterDeath;
        }
        if(Input.GetKeyDown(KeyCode.G) && WaveOn == true)
        {
            NextWave();
        }
        if (WaveStart == true)
        {
            if(WaveOn == true)
                NextWave();
        }
    }
    void OnMonsterDeath()
    {
        MonsterRemainingAlive--;
        if(MonsterRemainingAlive == 0)
        {
                    
            WaveStart = false;
            WaveOn = true;
            
        }
    }
    void NextWave()
    {
        WaveOn = false;
        currentWaveNumber++;
        print("Wave: " + currentWaveNumber);
        if(currentWaveNumber - 1 < waves.Length)
        {
            currentWave = waves[currentWaveNumber - 1];
            MonsterRemainingToSpawn = currentWave.MonsterCount;
            MonsterRemainingAlive = MonsterRemainingToSpawn;
        }
        if (currentWaveNumber - 1 == waves.Length)
        {
            HeroWinBool = true;
        }

    }
     [System.Serializable]
    public class Wave
    {
        public int MonsterCount;
        public float timeBetweenSpawns;
    }

}
