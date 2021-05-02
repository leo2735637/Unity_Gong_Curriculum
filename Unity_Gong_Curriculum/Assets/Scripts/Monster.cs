using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 10)]
    public float speed = 3.5f;
    [Header("攻擊力"), Range(0, 500)]
    public int attack = 100;
    [Range(0, 5000)]
    public int hp = 350;
    [Header("掉落道具"), Tooltip("遊戲物件")]
    public bool Props = false;
    [Header("掉落道具機率"), Range(0, 1)]
    public int  Props1 = 1;
    [Header("掉落道具音效"), Tooltip("掉落聲音")]
    public AudioClip Gunshots;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
}

