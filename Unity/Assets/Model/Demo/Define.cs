namespace ET
{
	public static class Define
	{
#if UNITY_EDITOR && !ASYNC
		public static bool IsAsync = false;
#else
        public static bool IsAsync = true;
#endif
		public enum InputEvents{
            None = 0b0000,
            Moving = 0b0001,
            Attack = 0b0010,
            Jump = 0b0100,
            Jumping = 0b1000,
        }


    }
}