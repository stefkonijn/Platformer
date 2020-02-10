using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using Platformer.Mechanics;
using UnityEngine;
using static Platformer.Core.Simulation;

public class spikesManager : MonoBehaviour
{

    internal Collider2D _collider;
    internal AudioSource _audio;
    SpriteRenderer spriteRenderer;

    public Bounds Bounds => _collider.bounds;

    void Awake()
    {
        _collider = GetComponent<Collider2D>();
        _audio = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            var ev = Schedule<SpikesCollision>();
            ev.player = player;
        }
    }
}
