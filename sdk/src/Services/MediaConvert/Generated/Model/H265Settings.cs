/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for H265 codec
    /// </summary>
    public partial class H265Settings
    {
        private H265AdaptiveQuantization _adaptiveQuantization;
        private H265AlternateTransferFunctionSei _alternateTransferFunctionSei;
        private int? _bitrate;
        private H265CodecLevel _codecLevel;
        private H265CodecProfile _codecProfile;
        private H265FlickerAdaptiveQuantization _flickerAdaptiveQuantization;
        private H265FramerateControl _framerateControl;
        private H265FramerateConversionAlgorithm _framerateConversionAlgorithm;
        private int? _framerateDenominator;
        private int? _framerateNumerator;
        private H265GopBReference _gopBReference;
        private int? _gopClosedCadence;
        private double? _gopSize;
        private H265GopSizeUnits _gopSizeUnits;
        private int? _hrdBufferInitialFillPercentage;
        private int? _hrdBufferSize;
        private H265InterlaceMode _interlaceMode;
        private int? _maxBitrate;
        private int? _minIInterval;
        private int? _numberBFramesBetweenReferenceFrames;
        private int? _numberReferenceFrames;
        private H265ParControl _parControl;
        private int? _parDenominator;
        private int? _parNumerator;
        private H265QualityTuningLevel _qualityTuningLevel;
        private H265RateControlMode _rateControlMode;
        private H265SampleAdaptiveOffsetFilterMode _sampleAdaptiveOffsetFilterMode;
        private H265SceneChangeDetect _sceneChangeDetect;
        private int? _slices;
        private H265SlowPal _slowPal;
        private H265SpatialAdaptiveQuantization _spatialAdaptiveQuantization;
        private H265Telecine _telecine;
        private H265TemporalAdaptiveQuantization _temporalAdaptiveQuantization;
        private H265TemporalIds _temporalIds;
        private H265Tiles _tiles;
        private H265UnregisteredSeiTimecode _unregisteredSeiTimecode;
        private H265WriteMp4PackagingType _writeMp4PackagingType;

        /// <summary>
        /// Gets and sets the property AdaptiveQuantization.
        /// </summary>
        public H265AdaptiveQuantization AdaptiveQuantization
        {
            get { return this._adaptiveQuantization; }
            set { this._adaptiveQuantization = value; }
        }

        // Check to see if AdaptiveQuantization property is set
        internal bool IsSetAdaptiveQuantization()
        {
            return this._adaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property AlternateTransferFunctionSei.
        /// </summary>
        public H265AlternateTransferFunctionSei AlternateTransferFunctionSei
        {
            get { return this._alternateTransferFunctionSei; }
            set { this._alternateTransferFunctionSei = value; }
        }

        // Check to see if AlternateTransferFunctionSei property is set
        internal bool IsSetAlternateTransferFunctionSei()
        {
            return this._alternateTransferFunctionSei != null;
        }

        /// <summary>
        /// Gets and sets the property Bitrate. Average bitrate in bits/second. Required for VBR
        /// and CBR. For MS Smooth outputs, bitrates must be unique when rounded down to the nearest
        /// multiple of 1000.
        /// </summary>
        public int Bitrate
        {
            get { return this._bitrate.GetValueOrDefault(); }
            set { this._bitrate = value; }
        }

        // Check to see if Bitrate property is set
        internal bool IsSetBitrate()
        {
            return this._bitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CodecLevel.
        /// </summary>
        public H265CodecLevel CodecLevel
        {
            get { return this._codecLevel; }
            set { this._codecLevel = value; }
        }

        // Check to see if CodecLevel property is set
        internal bool IsSetCodecLevel()
        {
            return this._codecLevel != null;
        }

        /// <summary>
        /// Gets and sets the property CodecProfile.
        /// </summary>
        public H265CodecProfile CodecProfile
        {
            get { return this._codecProfile; }
            set { this._codecProfile = value; }
        }

        // Check to see if CodecProfile property is set
        internal bool IsSetCodecProfile()
        {
            return this._codecProfile != null;
        }

        /// <summary>
        /// Gets and sets the property FlickerAdaptiveQuantization.
        /// </summary>
        public H265FlickerAdaptiveQuantization FlickerAdaptiveQuantization
        {
            get { return this._flickerAdaptiveQuantization; }
            set { this._flickerAdaptiveQuantization = value; }
        }

        // Check to see if FlickerAdaptiveQuantization property is set
        internal bool IsSetFlickerAdaptiveQuantization()
        {
            return this._flickerAdaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateControl.
        /// </summary>
        public H265FramerateControl FramerateControl
        {
            get { return this._framerateControl; }
            set { this._framerateControl = value; }
        }

        // Check to see if FramerateControl property is set
        internal bool IsSetFramerateControl()
        {
            return this._framerateControl != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateConversionAlgorithm.
        /// </summary>
        public H265FramerateConversionAlgorithm FramerateConversionAlgorithm
        {
            get { return this._framerateConversionAlgorithm; }
            set { this._framerateConversionAlgorithm = value; }
        }

        // Check to see if FramerateConversionAlgorithm property is set
        internal bool IsSetFramerateConversionAlgorithm()
        {
            return this._framerateConversionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateDenominator. Framerate denominator.
        /// </summary>
        public int FramerateDenominator
        {
            get { return this._framerateDenominator.GetValueOrDefault(); }
            set { this._framerateDenominator = value; }
        }

        // Check to see if FramerateDenominator property is set
        internal bool IsSetFramerateDenominator()
        {
            return this._framerateDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FramerateNumerator. Framerate numerator - framerate is
        /// a fraction, e.g. 24000 / 1001 = 23.976 fps.
        /// </summary>
        public int FramerateNumerator
        {
            get { return this._framerateNumerator.GetValueOrDefault(); }
            set { this._framerateNumerator = value; }
        }

        // Check to see if FramerateNumerator property is set
        internal bool IsSetFramerateNumerator()
        {
            return this._framerateNumerator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GopBReference.
        /// </summary>
        public H265GopBReference GopBReference
        {
            get { return this._gopBReference; }
            set { this._gopBReference = value; }
        }

        // Check to see if GopBReference property is set
        internal bool IsSetGopBReference()
        {
            return this._gopBReference != null;
        }

        /// <summary>
        /// Gets and sets the property GopClosedCadence. Frequency of closed GOPs. In streaming
        /// applications, it is recommended that this be set to 1 so a decoder joining mid-stream
        /// will receive an IDR frame as quickly as possible. Setting this value to 0 will break
        /// output segmenting.
        /// </summary>
        public int GopClosedCadence
        {
            get { return this._gopClosedCadence.GetValueOrDefault(); }
            set { this._gopClosedCadence = value; }
        }

        // Check to see if GopClosedCadence property is set
        internal bool IsSetGopClosedCadence()
        {
            return this._gopClosedCadence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GopSize. GOP Length (keyframe interval) in frames or seconds.
        /// Must be greater than zero.
        /// </summary>
        public double GopSize
        {
            get { return this._gopSize.GetValueOrDefault(); }
            set { this._gopSize = value; }
        }

        // Check to see if GopSize property is set
        internal bool IsSetGopSize()
        {
            return this._gopSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GopSizeUnits.
        /// </summary>
        public H265GopSizeUnits GopSizeUnits
        {
            get { return this._gopSizeUnits; }
            set { this._gopSizeUnits = value; }
        }

        // Check to see if GopSizeUnits property is set
        internal bool IsSetGopSizeUnits()
        {
            return this._gopSizeUnits != null;
        }

        /// <summary>
        /// Gets and sets the property HrdBufferInitialFillPercentage. Percentage of the buffer
        /// that should initially be filled (HRD buffer model).
        /// </summary>
        public int HrdBufferInitialFillPercentage
        {
            get { return this._hrdBufferInitialFillPercentage.GetValueOrDefault(); }
            set { this._hrdBufferInitialFillPercentage = value; }
        }

        // Check to see if HrdBufferInitialFillPercentage property is set
        internal bool IsSetHrdBufferInitialFillPercentage()
        {
            return this._hrdBufferInitialFillPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HrdBufferSize. Size of buffer (HRD buffer model) in bits.
        /// For example, enter five megabits as 5000000.
        /// </summary>
        public int HrdBufferSize
        {
            get { return this._hrdBufferSize.GetValueOrDefault(); }
            set { this._hrdBufferSize = value; }
        }

        // Check to see if HrdBufferSize property is set
        internal bool IsSetHrdBufferSize()
        {
            return this._hrdBufferSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InterlaceMode.
        /// </summary>
        public H265InterlaceMode InterlaceMode
        {
            get { return this._interlaceMode; }
            set { this._interlaceMode = value; }
        }

        // Check to see if InterlaceMode property is set
        internal bool IsSetInterlaceMode()
        {
            return this._interlaceMode != null;
        }

        /// <summary>
        /// Gets and sets the property MaxBitrate. Maximum bitrate in bits/second.
        /// </summary>
        public int MaxBitrate
        {
            get { return this._maxBitrate.GetValueOrDefault(); }
            set { this._maxBitrate = value; }
        }

        // Check to see if MaxBitrate property is set
        internal bool IsSetMaxBitrate()
        {
            return this._maxBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinIInterval. Enforces separation between repeated (cadence)
        /// I-frames and I-frames inserted by Scene Change Detection. If a scene change I-frame
        /// is within I-interval frames of a cadence I-frame, the GOP is shrunk and/or stretched
        /// to the scene change I-frame. GOP stretch requires enabling lookahead as well as setting
        /// I-interval. The normal cadence resumes for the next GOP. This setting is only used
        /// when Scene Change Detect is enabled. Note: Maximum GOP stretch = GOP size + Min-I-interval
        /// - 1
        /// </summary>
        public int MinIInterval
        {
            get { return this._minIInterval.GetValueOrDefault(); }
            set { this._minIInterval = value; }
        }

        // Check to see if MinIInterval property is set
        internal bool IsSetMinIInterval()
        {
            return this._minIInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberBFramesBetweenReferenceFrames. Number of B-frames
        /// between reference frames.
        /// </summary>
        public int NumberBFramesBetweenReferenceFrames
        {
            get { return this._numberBFramesBetweenReferenceFrames.GetValueOrDefault(); }
            set { this._numberBFramesBetweenReferenceFrames = value; }
        }

        // Check to see if NumberBFramesBetweenReferenceFrames property is set
        internal bool IsSetNumberBFramesBetweenReferenceFrames()
        {
            return this._numberBFramesBetweenReferenceFrames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberReferenceFrames. Number of reference frames to use.
        /// The encoder may use more than requested if using B-frames and/or interlaced encoding.
        /// </summary>
        public int NumberReferenceFrames
        {
            get { return this._numberReferenceFrames.GetValueOrDefault(); }
            set { this._numberReferenceFrames = value; }
        }

        // Check to see if NumberReferenceFrames property is set
        internal bool IsSetNumberReferenceFrames()
        {
            return this._numberReferenceFrames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParControl.
        /// </summary>
        public H265ParControl ParControl
        {
            get { return this._parControl; }
            set { this._parControl = value; }
        }

        // Check to see if ParControl property is set
        internal bool IsSetParControl()
        {
            return this._parControl != null;
        }

        /// <summary>
        /// Gets and sets the property ParDenominator. Pixel Aspect Ratio denominator.
        /// </summary>
        public int ParDenominator
        {
            get { return this._parDenominator.GetValueOrDefault(); }
            set { this._parDenominator = value; }
        }

        // Check to see if ParDenominator property is set
        internal bool IsSetParDenominator()
        {
            return this._parDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParNumerator. Pixel Aspect Ratio numerator.
        /// </summary>
        public int ParNumerator
        {
            get { return this._parNumerator.GetValueOrDefault(); }
            set { this._parNumerator = value; }
        }

        // Check to see if ParNumerator property is set
        internal bool IsSetParNumerator()
        {
            return this._parNumerator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QualityTuningLevel.
        /// </summary>
        public H265QualityTuningLevel QualityTuningLevel
        {
            get { return this._qualityTuningLevel; }
            set { this._qualityTuningLevel = value; }
        }

        // Check to see if QualityTuningLevel property is set
        internal bool IsSetQualityTuningLevel()
        {
            return this._qualityTuningLevel != null;
        }

        /// <summary>
        /// Gets and sets the property RateControlMode.
        /// </summary>
        public H265RateControlMode RateControlMode
        {
            get { return this._rateControlMode; }
            set { this._rateControlMode = value; }
        }

        // Check to see if RateControlMode property is set
        internal bool IsSetRateControlMode()
        {
            return this._rateControlMode != null;
        }

        /// <summary>
        /// Gets and sets the property SampleAdaptiveOffsetFilterMode.
        /// </summary>
        public H265SampleAdaptiveOffsetFilterMode SampleAdaptiveOffsetFilterMode
        {
            get { return this._sampleAdaptiveOffsetFilterMode; }
            set { this._sampleAdaptiveOffsetFilterMode = value; }
        }

        // Check to see if SampleAdaptiveOffsetFilterMode property is set
        internal bool IsSetSampleAdaptiveOffsetFilterMode()
        {
            return this._sampleAdaptiveOffsetFilterMode != null;
        }

        /// <summary>
        /// Gets and sets the property SceneChangeDetect.
        /// </summary>
        public H265SceneChangeDetect SceneChangeDetect
        {
            get { return this._sceneChangeDetect; }
            set { this._sceneChangeDetect = value; }
        }

        // Check to see if SceneChangeDetect property is set
        internal bool IsSetSceneChangeDetect()
        {
            return this._sceneChangeDetect != null;
        }

        /// <summary>
        /// Gets and sets the property Slices. Number of slices per picture. Must be less than
        /// or equal to the number of macroblock rows for progressive pictures, and less than
        /// or equal to half the number of macroblock rows for interlaced pictures.
        /// </summary>
        public int Slices
        {
            get { return this._slices.GetValueOrDefault(); }
            set { this._slices = value; }
        }

        // Check to see if Slices property is set
        internal bool IsSetSlices()
        {
            return this._slices.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SlowPal.
        /// </summary>
        public H265SlowPal SlowPal
        {
            get { return this._slowPal; }
            set { this._slowPal = value; }
        }

        // Check to see if SlowPal property is set
        internal bool IsSetSlowPal()
        {
            return this._slowPal != null;
        }

        /// <summary>
        /// Gets and sets the property SpatialAdaptiveQuantization.
        /// </summary>
        public H265SpatialAdaptiveQuantization SpatialAdaptiveQuantization
        {
            get { return this._spatialAdaptiveQuantization; }
            set { this._spatialAdaptiveQuantization = value; }
        }

        // Check to see if SpatialAdaptiveQuantization property is set
        internal bool IsSetSpatialAdaptiveQuantization()
        {
            return this._spatialAdaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property Telecine.
        /// </summary>
        public H265Telecine Telecine
        {
            get { return this._telecine; }
            set { this._telecine = value; }
        }

        // Check to see if Telecine property is set
        internal bool IsSetTelecine()
        {
            return this._telecine != null;
        }

        /// <summary>
        /// Gets and sets the property TemporalAdaptiveQuantization.
        /// </summary>
        public H265TemporalAdaptiveQuantization TemporalAdaptiveQuantization
        {
            get { return this._temporalAdaptiveQuantization; }
            set { this._temporalAdaptiveQuantization = value; }
        }

        // Check to see if TemporalAdaptiveQuantization property is set
        internal bool IsSetTemporalAdaptiveQuantization()
        {
            return this._temporalAdaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property TemporalIds.
        /// </summary>
        public H265TemporalIds TemporalIds
        {
            get { return this._temporalIds; }
            set { this._temporalIds = value; }
        }

        // Check to see if TemporalIds property is set
        internal bool IsSetTemporalIds()
        {
            return this._temporalIds != null;
        }

        /// <summary>
        /// Gets and sets the property Tiles.
        /// </summary>
        public H265Tiles Tiles
        {
            get { return this._tiles; }
            set { this._tiles = value; }
        }

        // Check to see if Tiles property is set
        internal bool IsSetTiles()
        {
            return this._tiles != null;
        }

        /// <summary>
        /// Gets and sets the property UnregisteredSeiTimecode.
        /// </summary>
        public H265UnregisteredSeiTimecode UnregisteredSeiTimecode
        {
            get { return this._unregisteredSeiTimecode; }
            set { this._unregisteredSeiTimecode = value; }
        }

        // Check to see if UnregisteredSeiTimecode property is set
        internal bool IsSetUnregisteredSeiTimecode()
        {
            return this._unregisteredSeiTimecode != null;
        }

        /// <summary>
        /// Gets and sets the property WriteMp4PackagingType.
        /// </summary>
        public H265WriteMp4PackagingType WriteMp4PackagingType
        {
            get { return this._writeMp4PackagingType; }
            set { this._writeMp4PackagingType = value; }
        }

        // Check to see if WriteMp4PackagingType property is set
        internal bool IsSetWriteMp4PackagingType()
        {
            return this._writeMp4PackagingType != null;
        }

    }
}