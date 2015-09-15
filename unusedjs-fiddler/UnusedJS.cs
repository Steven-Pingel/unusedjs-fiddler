using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdgeJs;
using Fiddler;

namespace unusedjs_fiddler
{
    public class UnusedJs : IAutoTamper 
    {
        // Called when Fiddler User Interface is fully available
        public void OnLoad()
        {
            throw new NotImplementedException();
        }

        // Called when Fiddler is shutting down
        public void OnBeforeUnload()
        {
            throw new NotImplementedException();
        }

        // Called after the user has had the chance to edit the request using the Fiddler Inspectors, but before the request is sent
        public void AutoTamperRequestAfter(Session oSession)
        {
            throw new NotImplementedException();
        }

        // Called before the user can edit a request using the Fiddler Inspectors
        public void AutoTamperRequestBefore(Session oSession)
        {
            throw new NotImplementedException();
        }

        // Called after the user edited a response using the Fiddler Inspectors.  Not called when streaming.
        public void AutoTamperResponseAfter(Session oSession)
        {
            throw new NotImplementedException();
        }

        // Called before the user can edit a response using the Fiddler Inspectors, unless streaming.
        public void AutoTamperResponseBefore(Session oSession)
        {
            throw new NotImplementedException();
        }

        // Called Fiddler returns a self-generated HTTP error (for instance DNS lookup failed, etc)
        public void OnBeforeReturningError(Session oSession)
        {
            throw new NotImplementedException();
        }
    }
}
