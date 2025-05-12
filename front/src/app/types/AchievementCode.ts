export type AchievementCode =
  | 'OfficialMember'
  | 'EmailVerified'
  | 'ProfileCompleted'
  | 'NoviceBass'
  | 'IntermediateBass'
  | 'AdvancedBass'
  | 'ExpertBass'
  | 'MasterBass'
  | 'NoviceAlto'
  | 'IntermediateAlto'
  | 'AdvancedAlto'
  | 'ExpertAlto'
  | 'MasterAlto'
  | 'NoviceTreble'
  | 'IntermediateTreble'
  | 'AdvancedTreble'
  | 'ExpertTreble'
  | 'MasterTreble'
  | 'Level2Achieved'
  | 'Level3Achieved'
  | 'Level4Achieved'
  | 'Level5Achieved'
  | 'Level6Achieved'
  | 'Level7Achieved'
  | 'WoodLeague'
  | 'StoneLeague'
  | 'BronzeLeague'
  | 'SilverLeague'
  | 'CrystalLeague'
  | 'EliteLeague'
  | 'ChampionLeague'
  | 'LegendLeague';


export function levelReachedCode(level: number): AchievementCode {
  return `Level${level}Achieved` as AchievementCode
}