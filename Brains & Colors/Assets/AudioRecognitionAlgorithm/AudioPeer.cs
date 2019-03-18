using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioPeer : MonoBehaviour
{
    AudioSource _audioSource;
    public static float[] _samples = new float[512];

    public static float[] _freqBand = new float[8];
    public static float[] _bandBuffer = new float[8];
    float[] _bufferDecrease = new float[8];
    float[] _freqBandHighest = new float[8];

    public static float[] _audioBand = new float[8];
    public static float[] _audioBandBuffer = new float[8];

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrucmAudioSource();
        MakeFrequencyBands();
        BandBuffer();
        CreateAudioBands();
    }
    void GetSpectrucmAudioSource()
    {
        _audioSource.GetSpectrumData(_samples,0,FFTWindow.Blackman);
    }

    void CreateAudioBands()
    {
        for (int x = 0; x < 8; x++)
        {
            if (_freqBand[x] > _freqBandHighest[x])
            {
                _freqBandHighest[x] = _freqBand[x];
            }
            _audioBand[x] = (_freqBand[x] / _freqBandHighest[x]);
            _audioBandBuffer[x] = (_bandBuffer[x] / _freqBandHighest[x]);
        }
    }
    void BandBuffer() //Makes sound bars be more accurate to the sound. 
    {
        for (int i = 0; i < 8; i++)
        {
            if (_freqBand[i] > _bandBuffer[i])
            {
                _bandBuffer[i] = _freqBand[i];
                _bufferDecrease[i] = 0.005f;

            }
            if (_freqBand[i] < _bandBuffer[i])
            {
                _bandBuffer[i] -= _bufferDecrease[i];
                _bufferDecrease[i] *= 1.2f;
            }
        }
    }
    void MakeFrequencyBands()
    {
        /*
         * 22050 hertz / 512 = 43hertz per sample
         * audio can be devided into 7 channels
         * 20-60 hz
         * 60-250 hz
         * 250-500
         * 500-2000
         * 2000-4000
         * 4000 - 6000
         * 6000 - 20000
         * 0 -2 = 86hz
         * 1 -4 = 172 hz  range= 87-258 hz 
         * 2
         * 3
         * 4
         * 5
         * 6
         * 7
         */

        int count = 0;
        for (int i = 0; i <8; i++)
        {
            int sampleCount = (int)Mathf.Pow(2,i)*2;
            float average = 0;
            if (i == 7)
            {
                sampleCount += 2;
            }
            for (int j = 0; j < sampleCount; j++)
            {
                average += _samples[count]*(count+1);

                count++;
            }
            average /= count;

            _freqBand[i] = average * 10;
        }
         
    }
}
