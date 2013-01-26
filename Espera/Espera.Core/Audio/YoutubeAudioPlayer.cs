﻿using Rareform.Validation;
using System;

namespace Espera.Core.Audio
{
    /// <summary>
    /// An <see cref="AudioPlayer"/> that streams songs from YouTube.
    /// </summary>
    internal sealed class YoutubeAudioPlayer : AudioPlayer, IVideoPlayerCallback
    {
        private bool isPaused;
        private bool isPlaying;
        private bool isStopped;

        public YoutubeAudioPlayer(YoutubeSong song)
        {
            if (song == null)
                Throw.ArgumentNullException(() => song);

            this.Song = song;
        }

        public override TimeSpan CurrentTime
        {
            get { return this.GetTime(); }
            set { this.SetTime(value); }
        }

        public Func<TimeSpan> GetTime { set; private get; }

        public Func<float> GetVolume { set; private get; }

        public Action LoadRequest { set; private get; }

        public Action PauseRequest { set; private get; }

        public override AudioPlayerState PlaybackState
        {
            get
            {
                if (this.isPlaying)
                    return AudioPlayerState.Playing;

                if (this.isPaused)
                    return AudioPlayerState.Paused;

                if (this.isStopped)
                    return AudioPlayerState.Stopped;

                return AudioPlayerState.None;
            }
        }

        public Action PlayRequest { set; private get; }

        public Action<TimeSpan> SetTime { set; private get; }

        public Action<float> SetVolume { set; private get; }

        public Action StopRequest { set; private get; }

        public override TimeSpan TotalTime
        {
            get { return this.Song.Duration; }
        }

        public Uri VideoUrl
        {
            get { return new Uri(this.Song.StreamingPath); }
        }

        public override float Volume
        {
            get { return this.GetVolume(); }
            set { this.SetVolume(value); }
        }

        public override void Dispose()
        {
            this.Stop();
        }

        public void Finished()
        {
            this.isPlaying = false;
            this.isStopped = true;

            this.OnSongFinished();
        }

        public override void Load()
        {
            this.LoadRequest();
        }

        public override void Pause()
        {
            this.PauseRequest();

            this.isPlaying = false;
            this.isPaused = true;
        }

        public override void Play()
        {
            this.PlayRequest();

            this.isPlaying = true;
            this.isPaused = false;
        }

        public override void Stop()
        {
            this.StopRequest();

            this.isStopped = true;
        }
    }
}