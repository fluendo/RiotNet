﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RiotNet.Models
{
    /// <summary>
    /// This object contains all timeline information.
    /// </summary>
    [ComplexType]
    public class MatchParticipantTimeline
    {
        /// <summary>
        /// Gets or sets ancient golem assists per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData AncientGolemAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets ancient golem kills per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData AncientGolemKillsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets assisted lane deaths per minute timeline data.
        /// </summary>
        public MatchParticipantTimelineData AssistedLaneDeathsPerMinDeltas { get; set; }

        /// <summary>
        /// Gets or sets assisted lane kills per minute timeline data.
        /// </summary>
        public MatchParticipantTimelineData AssistedLaneKillsPerMinDeltas { get; set; }

        /// <summary>
        /// Gets or sets baron assists per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData BaronAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets baron kills per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData BaronKillsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets creeps per minute timeline data.
        /// </summary>
        public MatchParticipantTimelineData CreepsPerMinDeltas { get; set; }

        /// <summary>
        /// Gets or sets creep score difference per minute timeline data
        /// </summary>
        public MatchParticipantTimelineData CsDiffPerMinDeltas { get; set; }

        /// <summary>
        /// Gets or sets damage taken difference per minute timeline data.
        /// </summary>
        public MatchParticipantTimelineData DamageTakenDiffPerMinDeltas { get; set; }

        /// <summary>
        /// Gets or sets damage taken per minute timeline data.
        /// </summary>
        public MatchParticipantTimelineData DamageTakenPerMinDeltas { get; set; }

        /// <summary>
        /// Gets or sets dragon assists per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData DragonAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets dragon kills per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData DragonKillsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets elder lizard assists per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData ElderLizardAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets elder lizard kills per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData ElderLizardKillsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets gold per minute timeline data.
        /// </summary>
        public MatchParticipantTimelineData GoldPerMinDeltas { get; set; }

        /// <summary>
        /// Gets or sets inhibitor assists per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData InhibitorAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets inhibitor kills per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData InhibitorKillsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets the participant's lane.
        /// </summary>
        // TODO: create converter so that "MID" and "MIDDLE", and "BOT" and "BOTTOM" are converted to same thing.
        public PlayerPosition Lane { get; set; }

        /// <summary>
        /// Gets or sets the participant's role.
        /// </summary>
        public MatchRole Role { get; set; }

        /// <summary>
        /// Gets or sets tower assists per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData TowerAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets tower kills per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData TowerKillsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets tower kills per minute timeline data.
        /// </summary>
        public MatchParticipantTimelineData TowerKillsPerMinDeltas { get; set; }

        /// <summary>
        /// Gets or sets vilemaw assists per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData VilemawAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets vilemaw kills per minute timeline counts.
        /// </summary>
        public MatchParticipantTimelineData VilemawKillsPerMinCounts { get; set; }

        /// <summary>
        /// Gets or sets wards placed per minute timeline data.
        /// </summary>
        public MatchParticipantTimelineData WardsPerMinDeltas { get; set; }

        /// <summary>
        /// Gets or sets experience difference per minute timeline data.
        /// </summary>
        public MatchParticipantTimelineData XpDiffPerMinDeltas { get; set; }

        /// <summary>
        /// Gets or sets experience per minute timeline data.
        /// </summary>
        public MatchParticipantTimelineData XpPerMinDeltas { get; set; }
    }
}