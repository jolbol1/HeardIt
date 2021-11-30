using System.Threading.Tasks;
using Google.Cloud.TextToSpeech.V1;

namespace HeardIt.Helpers
{

    public interface IGoogleTts
    {
        Task<string> AudioBase64Tts(string text);
    }
    
    public class GoogleTts : IGoogleTts
    {
        private TextToSpeechClient? _client;
        
        public async Task<string> AudioBase64Tts(string text)
        {
            if(_client == null)
            {
                _client = await TextToSpeechClient.CreateAsync();
            }

            if (string.IsNullOrEmpty(text))
            {
                return "";
            }
            AudioConfig audioConfig = new() {AudioEncoding = AudioEncoding.Mp3};
            VoiceSelectionParams voiceSelectionParams = new()
            {
                LanguageCode = "en-US",
            };
            if (text.Length > 5000)
            {
                text = text[..5000];
            }
            var input = new SynthesisInput {Text = text};
            var response = await _client.SynthesizeSpeechAsync(input, voiceSelectionParams, audioConfig);
            string _base64 = response.AudioContent.ToBase64();
            return "data:audio/mp3;base64," + _base64;
        }
        
    }
}