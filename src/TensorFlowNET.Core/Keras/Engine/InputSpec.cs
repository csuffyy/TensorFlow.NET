﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tensorflow.Keras.Engine
{
    /// <summary>
    /// Specifies the ndim, dtype and shape of every input to a layer.
    /// </summary>
    public class InputSpec
    {
        public int ndim;
        Dictionary<int, int> axes;

        public InputSpec(TF_DataType dtype = TF_DataType.DtInvalid, 
            int? ndim = null,
            Dictionary<int, int> axes = null)
        {
            this.ndim = ndim.Value;
            if (axes == null)
                axes = new Dictionary<int, int>();
            this.axes = axes;
        }
    }
}
