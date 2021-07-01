using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class InputComponent : Entity
    {
        public Define.InputEvents inputEvents
        {
            get; set;
        } = Define.InputEvents.None;
        
    }
}