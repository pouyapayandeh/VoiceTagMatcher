using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NAudio.Wave;

namespace VoiceTagMatcher
{
    class AudioPlayback
    {
        private static void TrimWavFile(WaveFileReader reader, WaveFileWriter writer, int startPos, int endPos)
        {
            reader.Position = startPos;
            byte[] buffer = new byte[1024];
            while (reader.Position < endPos)
            {
                int bytesRequired = (int)(endPos - reader.Position);
                if (bytesRequired > 0)
                {
                    int bytesToRead = Math.Min(bytesRequired, buffer.Length);
                    int bytesRead = reader.Read(buffer, 0, bytesToRead);
                    if (bytesRead > 0)
                    {
                        writer.WriteData(buffer, 0, bytesRead);
                    }
                }
            }
        }
        public static void TrimPlayWAvFile(string inPath, TimeSpan cutFromStart, TimeSpan cutFromEnd)
        {
            MemoryStream memoryStream = new MemoryStream();
            using (WaveFileReader reader = new WaveFileReader(inPath))
            {

                using (WaveFileWriter writer = new WaveFileWriter(memoryStream, reader.WaveFormat))
                {
                    int bytesPerMillisecond = reader.WaveFormat.AverageBytesPerSecond / 1000;

                    int startPos = (int)cutFromStart.TotalMilliseconds * bytesPerMillisecond;
                    if (startPos < 0)
                        startPos = 0;
                    startPos = startPos - startPos % reader.WaveFormat.BlockAlign;

                    int endBytes = (int)cutFromEnd.TotalMilliseconds * bytesPerMillisecond;
                    endBytes = endBytes - endBytes % reader.WaveFormat.BlockAlign;
                    int endPos = endBytes;
                    //   int endPos = (int)reader.Length - endBytes;
                    if (endPos > (int)reader.Length)
                        endPos = (int)reader.Length;
                    TrimWavFile(reader, writer, startPos, endPos);

                }
            }
            IWavePlayer waveOutDevice;
            waveOutDevice = new WaveOut();
            WaveStream wmaReader = new WaveFileReader(new MemoryStream(memoryStream.GetBuffer()));
            waveOutDevice.Init(wmaReader);
            waveOutDevice.Play();
//            if (waveOutDevice != null)
//            {
//                waveOutDevice.Stop();
//            }
//            if (wmaReader != null)
//            {
//                wmaReader.Dispose();
//                wmaReader = null;
//            }

        }
    }
}
