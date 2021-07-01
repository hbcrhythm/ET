using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [ObjectSystem]
    public class InputComponentDestroySystem : DestroySystem<InputComponent>
    {
        public override void Destroy(InputComponent self)
        {
            self.Clear();
        }
    }

    [ObjectSystem]
    public class InputComponentAwakeSystem : AwakeSystem<InputComponent>
    {
        public override void Awake(InputComponent self)
        {

        }
    }

    public class InputComponentUpdateSystem : UpdateSystem<InputComponent>
    {
        public override void Update(InputComponent self)
        {
            self.Update();
        }
    }

    public static class InputComponentSystem {

        public static void Update(this InputComponent self)
        { 
            
        }
        public static void Clear(this InputComponent self)
        { 
            
        }
    }
}
