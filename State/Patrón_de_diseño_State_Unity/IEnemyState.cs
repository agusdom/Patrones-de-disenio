using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public interface IEnemyState
    {
        Task<StateResult> DoAction(object data);
    }

