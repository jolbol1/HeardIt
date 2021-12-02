using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.TextToSpeech.V1;
using Google.Protobuf.Collections;

namespace HeardIt.Helpers
{

    public interface IGoogleTts
    {
        Task<string> AudioBase64Tts(string text, VoiceSelectionParams? voiceSelectionParams);
        Task<IEnumerable<string>> GetLanguages();

        Task<RepeatedField<Voice>> GetVoicesForLanguage(string language);


    }
    
    public class GoogleTts : IGoogleTts
    {
        private TextToSpeechClient? _client;
        
        public async Task<IEnumerable<string>> GetLanguages()
        {
            _client ??= await TextToSpeechClient.CreateAsync();

            var voices = await _client.ListVoicesAsync("");
            
            var x =  voices.Voices.Select(x => x.LanguageCodes).Distinct();
            return x.Select(repeatedField => repeatedField[0]).OrderBy(r => r);
        }

        public async Task<RepeatedField<Voice>> GetVoicesForLanguage(string language)
        {
            _client ??= await TextToSpeechClient.CreateAsync();
            var voices = await _client.ListVoicesAsync(language);
            return voices.Voices;
        }
        
        public async Task<string> AudioBase64Tts(string text, VoiceSelectionParams? voiceSelectionParams)
        {
            _client ??= await TextToSpeechClient.CreateAsync();
            voiceSelectionParams ??= new VoiceSelectionParams
            {
                LanguageCode = "en-US",
            };

            if (string.IsNullOrEmpty(text))
            {
                return "";
            }
            AudioConfig audioConfig = new() {AudioEncoding = AudioEncoding.OggOpus};
            
            if (text.Length > 5000)
            {
                text = text[..5000];
            }
            var input = new SynthesisInput {Text = text};
            var response = await _client.SynthesizeSpeechAsync(input, voiceSelectionParams, audioConfig);
            string _base64 = response.AudioContent.ToBase64();
            return "data:audio/ogg;base64," + _base64;
        }
        
    }
}