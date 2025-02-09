using System.Speech.Synthesis;
using Xabe.FFmpeg;

namespace Text2Video
{
    public class Text2VideoService
    {
        // Convert Text to Speech using System.Speech
        public static void ConvertTextToSpeech(string text, string outputFile, string selectedVoice)
        {
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                synthesizer.SelectVoice(selectedVoice);
                synthesizer.SetOutputToDefaultAudioDevice();
                synthesizer.Speak(text);
            }
            Console.WriteLine("Audio generated: " + outputFile);
        }

        //Generate an Image with Text
        public static void CreateImageWithText(string text, string outputFile)
        {
            int width = 1280, height = 720;
            using (System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(width, height))
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap))
            {
                graphics.Clear(System.Drawing.Color.Black);
                using (System.Drawing.Font font = new System.Drawing.Font("Arial", 32))
                using (System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(System.Drawing.Color.White))
                {
                    graphics.DrawString(text, font, brush, new System.Drawing.PointF(100, 300));
                }
                bitmap.Save(outputFile);
            }
            Console.WriteLine("Image generated: " + outputFile);
        }

        // Create Video from Image & Audio using FFmpeg
        public static async Task CreateVideoFromImageAndAudio(string image, string audio, string outputVideo)
        {
        //    var conversion = await FFmpeg.Conversions.FromSnippet.SlideShow(new[] { image }, 5); // 5 sec duration
        //    conversion.AddAudio(audio);
        //    await conversion.Start();
        //    Console.WriteLine("Video created: " + outputVideo);
        }
    }
}
