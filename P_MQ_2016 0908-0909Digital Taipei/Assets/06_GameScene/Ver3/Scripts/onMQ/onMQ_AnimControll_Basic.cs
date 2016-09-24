﻿using UnityEngine;
using System.Collections;

public class onMQ_AnimControll_Basic : MonoBehaviour {
    public int myMQAniMod;//0攻擊1待機234
    public Animator myAniam;
    public GameObject myFather;
    // Use this for initialization
    void Start(){myAniam = gameObject.GetComponent<Animator>();}

    onMonsterVer3 onMonster3;
    // Update is called once per frame
    void Update()
    {
        myMQAniMod = myFather.GetComponent<onMQVer3>().myMQAniMod;
        myMQAnimController();
    }
    public void myMQAnimController()
    {
        switch (myMQAniMod)
        {
            case 0:
                myAniam.Play("SoliderAttack");
                break;
            case 1:
                myAniam.Play("SoliderBasic");
                break;
            case 2:
                myAniam.Play("SoldierCharge_loop");
                break;
            case 3:
                myAniam.Play("SoliderHit");
                break;
            case 4:
                myAniam.Play("SoliderRotation");
                break;
            default:
                break;
        }
    }
    public void OnLastFram_Attack()
    {
        //print("1s OnLastFram_Attack be call");
        myFather.GetComponent<onMQVer3>().myAttackTimer = 0;
        //1秒打一下
        if (myFather.GetComponent<onMQVer3>().myTargetPoint.name == "hitpoint-1")
        {
            int a = Random.Range(0, 101);
            if (a < myFather.GetComponent<onMQVer3>().myCritHit) {
                /*
                
                */

                int crithit = (int)Random.Range(myFather.GetComponent<onMQVer3>().myAttack * 2, myFather.GetComponent<onMQVer3>().myAttack * 2.8f);
                onMonster3 = myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myFatherObject.GetComponent<onMonsterVer3>();
                onMonster3.Hitmob(crithit, 1);
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myHP -= (int)crithit;
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myFatherObject.GetComponent<onMonsterVer3>().myHP -= (int)crithit;
            }
            else {
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myHP -= myFather.GetComponent<onMQVer3>().myAttack;
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myFatherObject.GetComponent<onMonsterVer3>().myHP -= myFather.GetComponent<onMQVer3>().myAttack;
            }
        }
        if (myFather.GetComponent<onMQVer3>().myTargetPoint.name == "hitpoint-2")
        {
            int a = Random.Range(0, 101);
            if (a < myFather.GetComponent<onMQVer3>().myCritHit) {
                int crithit = (int)Random.Range(myFather.GetComponent<onMQVer3>().myAttack * 2, myFather.GetComponent<onMQVer3>().myAttack * 2.8f);
                onMonster3 = myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myFatherObject.GetComponent<onMonsterVer3>();
                onMonster3.Hitmob(crithit, 1);
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myHP -= (int)crithit;
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myFatherObject.GetComponent<onMonsterVer3>().myHP -= (int)crithit;
            }
            else {
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myHP -= myFather.GetComponent<onMQVer3>().myAttack;
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myFatherObject.GetComponent<onMonsterVer3>().myHP -= myFather.GetComponent<onMQVer3>().myAttack/ myFather.GetComponent<onMQVer3>().myAttack;
            }
        }
        if (myFather.GetComponent<onMQVer3>().myTargetPoint.name == "hitpoint-3")
        {
            int a = Random.Range(0, 101);
            if (a < myFather.GetComponent<onMQVer3>().myCritHit) {
                int crithit = (int)Random.Range(myFather.GetComponent<onMQVer3>().myAttack * 2, myFather.GetComponent<onMQVer3>().myAttack * 2.8f);
                onMonster3 = myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myFatherObject.GetComponent<onMonsterVer3>();
                onMonster3.Hitmob(crithit, 1);
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myHP -= (int)crithit;
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myFatherObject.GetComponent<onMonsterVer3>().myHP -= (int)crithit;
            }
            else {
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myHP -= myFather.GetComponent<onMQVer3>().myAttack;
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myFatherObject.GetComponent<onMonsterVer3>().myHP -= myFather.GetComponent<onMQVer3>().myAttack/ myFather.GetComponent<onMQVer3>().myAttack;
            }
        }
        if (myFather.GetComponent<onMQVer3>().myTargetPoint.name == "hitpoint-4" || myFather.GetComponent<onMQVer3>().myTargetPoint.name == "hitpoint-5")
        {
            int a = Random.Range(0, 101);
            if (a < myFather.GetComponent<onMQVer3>().myCritHit) {
                int crithit = (int)Random.Range(myFather.GetComponent<onMQVer3>().myAttack * 2, myFather.GetComponent<onMQVer3>().myAttack * 2.8f);
                onMonster3 = myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myFatherObject.GetComponent<onMonsterVer3>();
                onMonster3.Hitmob(crithit, 1);
                GameObject.Find("hitpoint-4").GetComponent<OnLookAtPoint>().myHP -= crithit;
                GameObject.Find("hitpoint-5").GetComponent<OnLookAtPoint>().myHP -= crithit;
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myFatherObject.GetComponent<onMonsterVer3>().myHP -= crithit;
            }
            else {
                GameObject.Find("hitpoint-4").GetComponent<OnLookAtPoint>().myHP -= myFather.GetComponent<onMQVer3>().myAttack;
                GameObject.Find("hitpoint-5").GetComponent<OnLookAtPoint>().myHP -= myFather.GetComponent<onMQVer3>().myAttack;
                myFather.GetComponent<onMQVer3>().myTargetPoint.GetComponent<OnLookAtPoint>().myFatherObject.GetComponent<onMonsterVer3>().myHP -= myFather.GetComponent<onMQVer3>().myAttack;
            }
        }
    }
    public void onFirstFram_Hit() {myAniam.speed = 1.5f;}
    public void OnMiddleFram_Hit(){}
    public void OnLastFram_Hit()
    {
        myAniam.speed = 1;
        myFather.GetComponent<onMQVer3>().isBeHit = false;
    }
}
