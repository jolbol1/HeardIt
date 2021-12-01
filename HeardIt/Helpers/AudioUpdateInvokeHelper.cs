using System;
using Microsoft.JSInterop;

namespace HeardIt.Helpers
{
    public class AudioUpdateInvokeHelper
    {
        private Action action;

        public AudioUpdateInvokeHelper(Action action)
        {
            this.action = action;
        }

        [JSInvokable("BlazorSample")]
        public void UpdateAudioCaller()
        {
            action.Invoke();
        }
    }
}