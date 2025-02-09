using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Text2Video;
using static System.Net.Mime.MediaTypeNames;

namespace Text2Video.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public string UserInput { get; set; } = string.Empty;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string text = "Hello Moksheet Sriram & Soumith Kumar.  I love you!!.";
            string audioFile = "output.wav";
            string mageFile = "slide.png";
            string videoFile = "output.mp4";
            string selectedVoice = "Microsoft David Desktop";

            // Step 1: Convert Text to Speech
            //Text2VideoService.ConvertTextToSpeech(text, audioFile, selectedVoice);

            // Step 2: Generate Image with Text
            //Text2VideoService.CreateImageWithText(text, imageFile);

            // Step 3: Combine Image & Audio into Video using FFmpeg
            //await Text2VideoService.CreateVideoFromImageAndAudio(imageFile, audioFile, videoFile);

            Console.WriteLine("Video generated successfully!");
        }
        public void OnPost()
        {
            if (!string.IsNullOrEmpty(UserInput))
            {
                string audioFile = "output.wav";
                string mageFile = "slide.png";
                string videoFile = "output.mp4";
                string selectedVoice = "Microsoft David Desktop";

                // Step 1: Convert Text to Speech
                Text2VideoService.ConvertTextToSpeech(UserInput, audioFile, selectedVoice);
                // Example: Convert text to uppercase
                //Result = $"You entered: {UserInput.ToUpper()}";
            }
        }
    }
}
