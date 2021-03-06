﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RataSimple : Enemy
{
    public List<Sprite> spritesHead;
    public List<Sprite> spritesBody;
    public List<Sprite> spritesArms;
    public SpriteRenderer head;
    public SpriteRenderer body;
    public SpriteRenderer arm1;
    public SpriteRenderer arm2;

    public override void Initialize(int _parameter)
    {
        head.sprite = spritesHead[Random.Range(0, spritesHead.Count)];
        int r = Random.Range(0, spritesBody.Count);
        body.sprite = spritesBody[r];
        arm1.sprite = spritesArms[r];
        arm2.sprite = spritesArms[r];

        int spd = 3;
        if (_parameter == 0)
            spd = 3;
        else if (_parameter == 1)
            spd = 5;

        this.GetComponent<VerticalMov>().SetSpeed(spd);
        base.Initialize(_parameter);

    }
}
