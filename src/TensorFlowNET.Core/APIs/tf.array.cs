﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tensorflow
{
    public static partial class tf
    {
        /// <summary>
        /// Inserts a dimension of 1 into a tensor's shape.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="axis"></param>
        /// <param name="name"></param>
        /// <param name="dim"></param>
        /// <returns>
        /// A `Tensor` with the same data as `input`, but its shape has an additional
        /// dimension of size 1 added.
        /// </returns>
        public static Tensor expand_dims(Tensor input, int axis = -1, string name = null, int dim = -1)
            => array_ops.expand_dims(input, axis, name, dim);

        /// <summary>
        /// Transposes `a`. Permutes the dimensions according to `perm`.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="perm"></param>
        /// <param name="name"></param>
        /// <param name="conjugate"></param>
        /// <returns></returns>
        public static Tensor transpose(Tensor a, int[] perm = null, string name = "transpose", bool conjugate = false)
            => array_ops.transpose(a, perm, name, conjugate);
    }
}
