﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System.Collections.Generic;

namespace Microsoft.Toolkit.Uwp.SampleApp.Models
{
    /// <summary>
    /// Common Metadata Attributes that appear on a <see cref="Sample"/>.
    /// </summary>
    public interface ISampleMetadata
    {
        /// <summary>
        /// Gets the name of the sample as it will appear in the UI.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the description of the sample when the user clicks the (i) info icon next to the sample listing.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the location of the icon representing this sample.
        /// </summary>
        string Icon { get; }

        /// <summary>
        /// Gets the OS minimum version required for this sample.
        /// </summary>
        string BadgeUpdateVersionRequired { get; } ////TODO: Do we want an enum here?

        /// <summary>
        /// Gets tags for search.
        /// </summary>
        List<string> Tags { get; }
    }
}
