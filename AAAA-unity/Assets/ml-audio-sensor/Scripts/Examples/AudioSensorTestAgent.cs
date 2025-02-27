﻿using UnityEngine;

public class AudioSensorTestAgent : AudioAgent
{
    public override void Initialize()
    {
        base.Initialize();
        m_Sampler.SamplingEnabled = true;
    }

    protected override void OnSamplingUpdate(int samplingStepCount, bool bufferLengthReached) 
    {
        Debug.Log($"Sampling Step Count: {samplingStepCount}");
    }
}