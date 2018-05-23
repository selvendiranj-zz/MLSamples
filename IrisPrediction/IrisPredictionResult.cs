using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace IrisPrediction
{
    // IrisPrediction is the result returned from prediction operations
    public class IrisPredictionResult
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabels;
    }
}
