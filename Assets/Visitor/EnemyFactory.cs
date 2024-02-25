﻿using System;
using UnityEngine;

namespace Assets.Visitor
{
    public class EnemyFactory: ScriptableObject
    {
        [SerializeField] private Human _humanPrefab;
        [SerializeField] private Ork _orkPrefab;
        [SerializeField] private Elf _elfPrefab;
        [SerializeField] private Robot _robotPrefab;

        public Enemy Get(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.Elf:
                    return Instantiate(_elfPrefab);

                case EnemyType.Human:
                    return Instantiate(_humanPrefab);

                case EnemyType.Ork:
                    return Instantiate(_orkPrefab);

                case EnemyType.Robot:
                    return Instantiate(_robotPrefab);

                default:
                    throw new ArgumentException(nameof(type));
            }
        }
    }
}
