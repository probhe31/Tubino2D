﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    public List<Horda> hordas;
    public Level(List<Horda> _hordas)
    {
        this.hordas = _hordas;
    }
}
public class Horda
{
    public int[] patterns;
    public Horda(int[] _patterns)
    {
        this.patterns = _patterns;
    }

}

public class LevelMan : MonoBehaviour
{
    //public int level = 0;
    bool generating = false;
    public EnemyFactory enemyFactory;
    public GameWeights gw;
    public Level level;
    //public List<Level> levels;
    //public List<Horda>
    //public int[] lvl1 = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };


    private void Awake()
    {
        enemyFactory = new EnemyFactory(this, gw);
        enemyFactory.Initialize();
    }

    


    public Level CreateLevel1()
    {
        List<Horda> lvl1 = new List<Horda>();
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, -1, -1, 3, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, -1, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, 0, -1, -1, -1, 0, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 3, 0, 0, 1, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1 }));
        return new Level(lvl1);
    }

    public Level CreateLevel2()
    {
        List<Horda> lvl1 = new List<Horda>();
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, -1, -1, 3, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, -1, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, 0, -1, -1, -1, 0, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 3, 0, 0, 1, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1 }));
        return new Level(lvl1);
    }

    public Level CreateLevel3()
    {
        List<Horda> lvl1 = new List<Horda>();
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, -1, -1, 3, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, -1, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, 0, -1, -1, -1, 0, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 3, 0, 0, 1, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1 }));
        return new Level(lvl1);
    }

    public Level CreateLevel4()
    {
        List<Horda> lvl1 = new List<Horda>();
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, -1, -1, 3, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, -1, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, 0, -1, -1, -1, 0, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 3, 0, 0, 1, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1 }));
        return new Level(lvl1);
    }

    public Level CreateLevel5()
    {
        List<Horda> lvl1 = new List<Horda>();
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, -1, -1, 3, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, -1, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, 0, -1, -1, -1, 0, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 3, 0, 0, 1, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1 }));
        return new Level(lvl1);
    }

    public Level CreateLevel6()
    {
        List<Horda> lvl1 = new List<Horda>();
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, -1, -1, 3, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, -1, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, 0, -1, -1, -1, 0, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 3, 0, 0, 1, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1 }));
        return new Level(lvl1);
    }

    public Level CreateLevel7()
    {
        List<Horda> lvl1 = new List<Horda>();
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, -1, -1, 3, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, -1, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, 0, -1, -1, -1, 0, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 3, 0, 0, 1, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1 }));
        return new Level(lvl1);
    }

    public Level CreateLevel8()
    {
        List<Horda> lvl1 = new List<Horda>();
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, -1, -1, 3, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, -1, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, 0, -1, -1, -1, 0, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 3, 0, 0, 1, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1 }));
        return new Level(lvl1);
    }

    public Level CreateLevel9()
    {
        List<Horda> lvl1 = new List<Horda>();
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, -1, -1, 3, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, -1, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, 0, -1, -1, -1, 0, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 3, 0, 0, 1, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1 }));
        return new Level(lvl1);
    }

    public Level CreateLevel10()
    {
        List<Horda> lvl1 = new List<Horda>();
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, -1, -1, -1, -1, 3, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, -1, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, -1, 0, -1, -1, -1, 0, -1, 0, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 }));
        lvl1.Add(new Horda(new int[15] { 0, 3, 0, 0, 1, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1 }));
        return new Level(lvl1);
    }

    public void StartGeneration(int lvl)
    {
        switch (lvl)
        {
            case 1:
                level = CreateLevel1();
                break;
            case 2:
                level = CreateLevel2();
                break;
            case 3:
                level = CreateLevel3();
                break;
            case 4:
                level = CreateLevel4();
                break;
            case 5:
                level = CreateLevel5();
                break;
            case 6:
                level = CreateLevel6();
                break;
            case 7:
                level = CreateLevel7();
                break;
            case 8:
                level = CreateLevel8();
                break;
            case 9:
                level = CreateLevel9();
                break;
            case 10:
                level = CreateLevel10();
                break;              
            
        }
        this.generating = true;
        enemyFactory.Create(level);
    }
    public void StopGeneration()
    {
        this.generating = false;
        enemyFactory.Stop();
    }
    void Update()
    {
        if (!generating)
            return;

        
    }


}
