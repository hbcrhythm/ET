using UnityEngine;
using System.Collections.Generic;
using Lean.Touch;

namespace Lean.Touch
{
	/// <summary>This component draws trails behind fingers.
	/// NOTE: This requires you to enable the LeanTouch.RecordFingers setting.</summary>
	[ExecuteInEditMode]
	[HelpURL(LeanTouch.HelpUrlPrefix + "LeanThumb")]
	[AddComponentMenu(LeanTouch.ComponentPathPrefix + "Thumb")]
	public class LeanThumb : MonoBehaviour
	{
		/// <summary>Ignore fingers with StartedOverGui?</summary>
		public bool IgnoreStartedOverGui = true;

		/// <summary>Ignore fingers with IsOverGui?</summary>
		public bool IgnoreIsOverGui;

		/// <summary>Do nothing if this LeanSelectable isn't selected?</summary>
		public LeanSelectable RequiredSelectable;

        //void OnEnable()
        //{
        //	LeanTouch.OnFingerTap += HandleFingerTap;
        //	LeanTouch.OnFingerSwipe += HandleFingerSwipe;
        //	LeanTouch.OnFingerTap += HandleFingerTap;
        //}

        //void OnDisable()
        //{
        //	LeanTouch.OnFingerTap -= HandleFingerTap;
        //	LeanTouch.OnFingerSwipe -= HandleFingerSwipe;
        //	LeanTouch.OnFingerTap -= HandleFingerTap;
        //}

        //void HandleFingerTap(Lean.Touch.LeanFinger finger)
        //{
        //	Debug.Log("You just tapped the screen with finger " + finger.Index + " at " + finger.ScreenPosition);
        //}

        //private void HandleFingerSwipe(LeanFinger finger)
        //{
        //	if (IgnoreStartedOverGui == true && finger.StartedOverGui == true)
        //	{
        //		return;
        //	}

        //	if (IgnoreIsOverGui == true && finger.IsOverGui == true)
        //	{
        //		return;
        //	}

        //	if (RequiredSelectable != null && RequiredSelectable.IsSelectedBy(finger) == false)
        //	{
        //		return;
        //	}

        //	HandleFingerSwipe(finger, finger.StartScreenPosition, finger.ScreenPosition);
        //}
        void OnEnable()
        {
        }

        void OnDisable()
        {
        }


        /// <summary>This method will update the Angle value based on the specified vector.</summary>
		[SerializeField]
        public void RotateToDelta(Vector2 delta)
        {
            Debug.Log($"RotateToDelta  {delta}");
        }

    }
}