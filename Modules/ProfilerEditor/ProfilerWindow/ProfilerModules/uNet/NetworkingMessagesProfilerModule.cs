// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Profiling;

namespace UnityEditorInternal.Profiling
{
    [Serializable]
    internal class NetworkingMessagesProfilerModule : ProfilerModuleBase
    {
        public override void DrawToolbar(Rect position)
        {
            DrawOtherToolbar(ProfilerArea.NetworkMessages);
        }

        public override void DrawView(Rect position)
        {
            DrawOverviewText(ProfilerArea.NetworkMessages, position);
        }
    }
}
