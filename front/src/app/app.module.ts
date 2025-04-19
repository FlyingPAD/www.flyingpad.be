import { HTTP_INTERCEPTORS, HttpClient, HttpClientModule } from '@angular/common/http';
import { TokenInterceptor } from './interceptors/token.interceptor';

import { APP_INITIALIZER, NgModule } from '@angular/core'
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CookieService } from 'ngx-cookie-service';
import { ToastrModule } from 'ngx-toastr';
import { ErrorInterceptor } from './interceptors/error.interceptor';
import { AboutComponent } from './pages/about/about.component';
import { HomeComponent } from './pages/home/home.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { LogInErrorComponent } from './pages/log-in-error/log-in-error.component';
import { UserRegisterComponent } from './pages/user-register/user-register.component';
import { LayoutEmptyComponent } from './layouts/layout-empty/layout-empty.component';
import { CircleOfFifthsComponent } from './features/tools/circle-of-fifths/circle-of-fifths.component';
import { DiapasonComponent } from './features/tools/diapason/diapason.component';
import { FlyingKeysMiniComponent } from './features/tools/flying-keys-mini/flying-keys-mini.component';
import { TrainerNotesComponent } from './features/tools/trainer-notes/trainer-notes.component';
import { ChordsComponent } from './features/scripts/chords/chords.component';
import { IntervalsComponent } from './features/scripts/intervals/intervals.component';
import { KeyRefComponent } from './features/scripts/key-ref/key-ref.component';
import { NotationComponent } from './features/scripts/notation/notation.component';
import { NotesTradComponent } from './features/scripts/notes-trad/notes-trad.component';
import { NotesComponent } from './features/scripts/notes/notes.component';
import { PulsationComponent } from './features/scripts/pulsation/pulsation.component';
import { ScalesComponent } from './features/scripts/scales/scales.component';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { NgxPaginationModule } from 'ngx-pagination';
import { ButtonBackComponent } from './components/button-back/button-back.component';
import { ButtonTopComponent } from './components/button-top/button-top.component';
import { CurrentTimeComponent } from './components/current-time/current-time.component';
import { DialogComponent } from './components/dialog/dialog.component';
import { AnimGrowDirective } from './directives/anim-grow.directive';
import { AnimRandomDirective } from './directives/anim-random.directive';
import { AnimSpinDirective } from './directives/anim-spin.directive';
import { FormatDurationPipe } from './pipes/format-duration.pipe';
import { FormatSizePipe } from './pipes/format-size.pipe';
import { CreateMoodImageComponent } from './pages/create-mood-image/create-mood-image.component';
import { CreateMoodVideoComponent } from './pages/create-mood-video/create-mood-video.component';
import { MultiTagArtistsComponent } from './pages/multi-tag-artists/multi-tag-artists.component';
import { MultiTagModelsComponent } from './pages/multi-tag-models/multi-tag-models.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { CreateArtistComponent } from './features/artists/create-artist/create-artist.component';
import { TagsComponent } from './pages/tags/tags.component';
import { ScriptsComponent } from './pages/scripts/scripts.component';
import { ToolsComponent } from './pages/tools/tools.component';
import { RelatedTagsComponent } from './features/moods/related-tags/related-tags.component';
import { ColumnFullComponent } from './features/tags/column-full/column-full.component';
import { BottomBarComponent } from './components/bottom-bar/bottom-bar.component';
import { DialogInfoComponent } from './components/dialog-info/dialog-info.component';
import { RightColumnComponent } from './components/right-column/right-column.component';
import { MediaComponent } from './pages/media/media.component';
import { LinksComponent } from './pages/links/links.component';
import { EditModelsComponent } from './pages/edit-models/edit-models.component';
import { EditTagsComponent } from './pages/edit-tags/edit-tags.component';
import { EditFranchisesComponent } from './pages/edit-franchises/edit-franchises.component';
import { EditArtistsComponent } from './pages/edit-artists/edit-artists.component';
import { EditLinksComponent } from './pages/edit-links/edit-links.component';
import { CreateModelComponent } from './features/models/create-model/create-model.component';
import { EditModelComponent } from './features/models/edit-model/edit-model.component';
import { EditTagComponent } from './features/tags/edit-tag/edit-tag.component';
import { CreateTagComponent } from './features/tags/create-tag/create-tag.component';
import { EditLinkComponent } from './features/links/edit-link/edit-link.component';
import { CreateLinkComponent } from './features/links/create-link/create-link.component';
import { EditArtistComponent } from './features/artists/edit-artist/edit-artist.component';
import { EditFranchiseComponent } from './features/franchises/edit-franchise/edit-franchise.component';
import { CreateFranchiseComponent } from './features/franchises/create-franchise/create-franchise.component';
import { EditTagCategoryComponent } from './features/tags/edit-tag-category/edit-tag-category.component';
import { DeleteModelComponent } from './features/models/delete-model/delete-model.component';
import { DeleteTagComponent } from './features/tags/delete-tag/delete-tag.component';
import { CreateTagCategoryComponent } from './features/tags/create-tag-category/create-tag-category.component';
import { DeleteTagCategoryComponent } from './features/tags/delete-tag-category/delete-tag-category.component';
import { DeleteFranchiseComponent } from './features/franchises/delete-franchise/delete-franchise.component';
import { DeleteArtistComponent } from './features/artists/delete-artist/delete-artist.component';
import { DeleteStyleComponent } from './features/artists/delete-style/delete-style.component';
import { CreateLinkCategoryComponent } from './features/links/create-link-category/create-link-category.component';
import { EditLinkCategoryComponent } from './features/links/edit-link-category/edit-link-category.component';
import { DeleteLinkComponent } from './features/links/delete-link/delete-link.component';
import { DeleteLinkCategoryComponent } from './features/links/delete-link-category/delete-link-category.component';
import { CreateStyleComponent } from './features/artists/create-style/create-style.component';
import { EditStyleComponent } from './features/artists/edit-style/edit-style.component';
import { CreateMediumComponent } from './features/franchises/create-medium/create-medium.component';
import { DeleteMediumComponent } from './features/franchises/delete-medium/delete-medium.component';
import { EditMediumComponent } from './features/franchises/edit-medium/edit-medium.component';
import { MultiTagComponent } from './pages/multi-tag/multi-tag.component';
import { FooterComponent } from './components/footer/footer.component';
import { TranslateLoader, TranslateModule, TranslateService } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { OverlayComponent } from './components/overlay/overlay.component';
import { SettingsComponent } from './pages/settings/settings.component';
import { FormatRatioPipe } from './pipes/format-ratio.pipe';
import { TimelineComponent } from './features/tools/timeline/timeline.component';
import { LocalizedDatePipe } from './pipes/localized-date.pipe';
import { GuitarTunerComponent } from './features/tools/guitar-tuner/guitar-tuner.component';
import { ChordWheelComponent } from './features/tools/chord-wheel/chord-wheel.component';
import { GdprComponent } from './components/gdpr/gdpr.component';
import { LeftColumnComponent } from './components/left-column/left-column.component';
import { HeaderHomeComponent } from './components/header-home/header-home.component';
import { LayoutHomeComponent } from './layouts/layout-home/layout-home.component';
import { SignUpComponent } from './pages/sign-up/sign-up.component';
import { LogInComponent } from './pages/log-in/log-in.component';
import { LayoutMoodsComponent } from './layouts/layout-moods/layout-moods.component';
import { HeaderMoodsComponent } from './components/header-moods/header-moods.component';
import { LanguageMenuHeaderComponent } from './components/language-menu-header/language-menu-header.component';
import { LayoutToolsComponent } from './layouts/layout-tools/layout-tools.component';
import { LanguageMenuHomeComponent } from './components/language-menu-home/language-menu-home.component';
import { AnimRotation360Directive } from './directives/anim-rotation-360.directive';
import { LayoutAboutComponent } from './layouts/layout-about/layout-about.component';
import { MusicPrinciplesComponent } from './features/scripts/music-principles/music-principles.component';
import { StatusComponent } from './features/dashboard/status/status.component';
import { AchievementsComponent } from './features/dashboard/achievements/achievements.component';
import { IconStarComponent } from './icons/icon-star/icon-star.component';
import { IconEditComponent } from './icons/icon-edit/icon-edit.component';
import { IconUserComponent } from './icons/icon-user/icon-user.component';
import { IconMoodComponent } from './icons/icon-mood/icon-mood.component';
import { IconStatisticsComponent } from './icons/icon-statistics/icon-statistics.component';
import { IconTagComponent } from './icons/icon-tag/icon-tag.component';
import { IconLinkComponent } from './icons/icon-link/icon-link.component';
import { IconDollarComponent } from './icons/icon-dollar/icon-dollar.component';
import { IconArtistComponent } from './icons/icon-artist/icon-artist.component';
import { IconModelComponent } from './icons/icon-model/icon-model.component';
import { DashboardEditionMenuComponent } from './features/dashboard/dashboard-edition-menu/dashboard-edition-menu.component';
import { AccountComponent } from './features/dashboard/account/account.component';
import { DashboardHeaderComponent } from './features/dashboard/dashboard-header/dashboard-header.component';
import { IconCoinComponent } from './icons/icon-coin/icon-coin.component';
import { IconHomeComponent } from './icons/icon-home/icon-home.component';
import { IconScriptComponent } from './icons/icon-script/icon-script.component';
import { IconToolsComponent } from './icons/icon-tools/icon-tools.component';
import { IconMoodsComponent } from './icons/icon-moods/icon-moods.component';
import { IconMediaComponent } from './icons/icon-media/icon-media.component';
import { IconLogoutComponent } from './icons/icon-logout/icon-logout.component';
import { IconSettingsComponent } from './icons/icon-settings/icon-settings.component';
import { IconHamburgerComponent } from './icons/icon-hamburger/icon-hamburger.component';
import { IconArrowComponent } from './icons/icon-arrow/icon-arrow.component';
import { IconQuestionComponent } from './icons/icon-question/icon-question.component';
import { IconInfoComponent } from './icons/icon-info/icon-info.component';
import { IconPlayComponent } from './icons/icon-play/icon-play.component';
import { IconStopComponent } from './icons/icon-stop/icon-stop.component';
import { IconResetComponent } from './icons/icon-reset/icon-reset.component';
import { IconPlusComponent } from './icons/icon-plus/icon-plus.component';
import { IconListComponent } from './icons/icon-list/icon-list.component';
import { IconGoComponent } from './icons/icon-go/icon-go.component';
import { IconBackComponent } from './icons/icon-back/icon-back.component';
import { IconArrowShortComponent } from './icons/icon-arrow-short/icon-arrow-short.component';
import { IconWheelComponent } from './icons/icon-wheel/icon-wheel.component';
import { IconOpenComponent } from './icons/icon-open/icon-open.component';
import { IconGoogleComponent } from './icons/icon-google/icon-google.component';
import { IconGoogleLensComponent } from './icons/icon-google-lens/icon-google-lens.component';
import { IconPlayShuffleComponent } from './icons/icon-play-shuffle/icon-play-shuffle.component';
import { LogoFacebookComponent } from './icons/logo-facebook/logo-facebook.component';
import { LogoInstagramComponent } from './icons/logo-instagram/logo-instagram.component';
import { LogoYoutubeComponent } from './icons/logo-youtube/logo-youtube.component';
import { LogoSoundcloudComponent } from './icons/logo-soundcloud/logo-soundcloud.component';
import { EditMoodComponent } from './pages/edit-mood/edit-mood.component';
import { EditMoodMenuComponent } from './features/moods/edit-mood-menu/edit-mood-menu.component';
import { IconSaveComponent } from './icons/icon-save/icon-save.component';
import { EditMoodThumbnailComponent } from './features/moods/edit-mood-thumbnail/edit-mood-thumbnail.component';
import { EditMoodModelsComponent } from './features/moods/edit-mood-models/edit-mood-models.component';
import { EditMoodArtistsComponent } from './features/moods/edit-mood-artists/edit-mood-artists.component';
import { EditMoodFormComponent } from './features/moods/edit-mood-form/edit-mood-form.component';
import { EditMoodTagsComponent } from './features/moods/edit-mood-tags/edit-mood-tags.component';
import { EditMoodScoreComponent } from './features/moods/edit-mood-score/edit-mood-score.component';
import { SpacerComponent } from './components/spacer/spacer.component';
import { IconDiapasonComponent } from './icons/icon-diapason/icon-diapason.component';
import { IconKeyboardComponent } from './icons/icon-keyboard/icon-keyboard.component';
import { MusicArsenalComponent } from './features/scripts/music-arsenal/music-arsenal.component';
import { IntroductionComponent } from './features/scripts/introduction/introduction.component';
import { RythmicArsenalComponent } from './features/scripts/rythmic-arsenal/rythmic-arsenal.component';
import { MelodicArsenalComponent } from './features/scripts/melodic-arsenal/melodic-arsenal.component';
import { HarmonicArsenalComponent } from './features/scripts/harmonic-arsenal/harmonic-arsenal.component';
import { IconTimelineComponent } from './icons/icon-timeline/icon-timeline.component';
import { TimbreComponent } from './features/scripts/timbre/timbre.component';
import { TonesComponent } from './features/scripts/tones/tones.component';
import { TimeValuesComponent } from './features/scripts/time-values/time-values.component';
import { IconClefBassComponent } from './icons/icon-clef-bass/icon-clef-bass.component';
import { IconClefTrebleComponent } from './icons/icon-clef-treble/icon-clef-treble.component';
import { IconClefAltoComponent } from './icons/icon-clef-alto/icon-clef-alto.component';
import { TheOctaveComponent } from './features/scripts/the-octave/the-octave.component';
import { PointOfViewComponent } from './features/scripts/point-of-view/point-of-view.component';
import { TimeSignatureComponent } from './features/scripts/time-signature/time-signature.component';
import { ScrollDirective } from './directives/scroll.directive';
import { TimeValueSixteenthComponent } from './icons/time-value-sixteenth/time-value-sixteenth.component';
import { TimeValueWholeComponent } from './icons/time-value-whole/time-value-whole.component';
import { TimeValueHalfComponent } from './icons/time-value-half/time-value-half.component';
import { TimeValueQuarterComponent } from './icons/time-value-quarter/time-value-quarter.component';
import { TimeValueEighthComponent } from './icons/time-value-eighth/time-value-eighth.component';
import { MultiTagTagsComponent } from './pages/multi-tag-tags/multi-tag-tags.component';
import { TimeValueRestEighthComponent } from './icons/time-value-rest-eighth/time-value-rest-eighth.component';
import { TimeValueRestSixteenthComponent } from './icons/time-value-rest-sixteenth/time-value-rest-sixteenth.component';
import { TimeValueRestHalfComponent } from './icons/time-value-rest-half/time-value-rest-half.component';
import { TimeValueRestQuarterComponent } from './icons/time-value-rest-quarter/time-value-rest-quarter.component';
import { TimeValueRestWholeComponent } from './icons/time-value-rest-whole/time-value-rest-whole.component';
import { environment } from '../environments/environment';
import { ScrollToTopDirective } from './directives/scroll-to-top.directive';
import { IconMenuRightComponent } from './icons/icon-menu-right/icon-menu-right.component';
import { ToggleMenuRightDirective } from './directives/toggle-menu-right.directive';
import { GoBackDirective } from './directives/go-back.directive';
import { MetronomeComponent } from './features/tools/metronome/metronome.component';
import { IconMetronomeComponent } from './icons/icon-metronome/icon-metronome.component';
import { GalleryComponent } from './features/moods/gallery/gallery.component';
import { MoodInformationsComponent } from './features/moods/mood-informations/mood-informations.component';
import { CentralGalleryComponent } from './pages/central-gallery/central-gallery.component';
import { RelatedModelsComponent } from './features/franchises/related-models/related-models.component';
import { RelatedFranchisesComponent } from './features/models/related-franchises/related-franchises.component';
import { RightColumnGenericListComponent } from './components/right-column-generic-list/right-column-generic-list.component';
import { BottomIconBackComponent } from './components/bottom-bar-icons/bottom-icon-back/bottom-icon-back.component';
import { BottomIconToTopComponent } from './components/bottom-bar-icons/bottom-icon-to-top/bottom-icon-to-top.component';
import { BottomIconSaveComponent } from './components/bottom-bar-icons/bottom-icon-save/bottom-icon-save.component';
import { BottomToggleRightMenuComponent } from './components/bottom-bar-icons/bottom-toggle-right-menu/bottom-toggle-right-menu.component';
import { BottomItemsLengthComponent } from './components/bottom-bar-icons/bottom-items-length/bottom-items-length.component';
import { BottomItemNameComponent } from './components/bottom-bar-icons/bottom-item-name/bottom-item-name.component';
import { BottomIconArtistComponent } from './components/bottom-bar-icons/bottom-icon-artist/bottom-icon-artist.component';
import { BottomIconModelComponent } from './components/bottom-bar-icons/bottom-icon-model/bottom-icon-model.component';
import { BottomIconTagComponent } from './components/bottom-bar-icons/bottom-icon-tag/bottom-icon-tag.component';
import { BottomIconEditComponent } from './components/bottom-bar-icons/bottom-icon-edit/bottom-icon-edit.component';
import { BottomIconMoodsComponent } from './components/bottom-bar-icons/bottom-icon-moods/bottom-icon-moods.component';
import { BottomIconOpenComponent } from './components/bottom-bar-icons/bottom-icon-open/bottom-icon-open.component';
import { BottomIconGoogleComponent } from './components/bottom-bar-icons/bottom-icon-google/bottom-icon-google.component';
import { BottomIconGoogleImageComponent } from './components/bottom-bar-icons/bottom-icon-google-image/bottom-icon-google-image.component';
import { BottomItemPositionComponent } from './components/bottom-bar-icons/bottom-item-position/bottom-item-position.component';
import { BottomIconPageNextComponent } from './components/bottom-bar-icons/bottom-icon-page-next/bottom-icon-page-next.component';
import { BottomIconPagePreviousComponent } from './components/bottom-bar-icons/bottom-icon-page-previous/bottom-icon-page-previous.component';
import { BottomIconDiaporamaComponent } from './components/bottom-bar-icons/bottom-icon-diaporama/bottom-icon-diaporama.component';
import { BottomIconShuffleComponent } from './components/bottom-bar-icons/bottom-icon-shuffle/bottom-icon-shuffle.component';
import { BottomIconRandomMoodComponent } from './components/bottom-bar-icons/bottom-icon-random-mood/bottom-icon-random-mood.component';
import { BottomIconDashboardEditionComponent } from './components/bottom-bar-icons/bottom-icon-dashboard-edition/bottom-icon-dashboard-edition.component';
import { BottomIconDashboardStatusComponent } from './components/bottom-bar-icons/bottom-icon-dashboard-status/bottom-icon-dashboard-status.component';
import { BottomIconDashboardAchievementsComponent } from './components/bottom-bar-icons/bottom-icon-dashboard-achievements/bottom-icon-dashboard-achievements.component';
import { BottomIconDashboardAccountComponent } from './components/bottom-bar-icons/bottom-icon-dashboard-account/bottom-icon-dashboard-account.component';
import { ChordWriterComponent } from './features/tools/chord-writer/chord-writer.component';
import { SongWriterComponent } from './features/tools/song-writer/song-writer.component';
import { SongWriterTestComponent } from './features/tools/song-writer-test/song-writer-test.component';
import { DragDropModule } from '@angular/cdk/drag-drop';
import { ToggleMoodInfoDirective } from './directives/toggle-mood-info.directive';
import { ToggleMoodSizeDirective } from './directives/toggle-mood-size.directive';
import { BottomToggleMoodSizeComponent } from './components/bottom-bar-icons/bottom-toggle-mood-size/bottom-toggle-mood-size.component';
import { BottomToggleMoodInfoComponent } from './components/bottom-bar-icons/bottom-toggle-mood-info/bottom-toggle-mood-info.component';
import { BottomToggleEntityInfoComponent } from './components/bottom-bar-icons/bottom-toggle-entity-info/bottom-toggle-entity-info.component';
import { ToggleDialogDirective } from './directives/toggle-dialog.directive';
import { PrototypeComponent } from './features/tools/prototype/prototype.component';
import { CreateMoodVideoYoutubeComponent } from './pages/create-mood-video-youtube/create-mood-video-youtube.component'

export function HttpLoaderFactory(http: HttpClient) {
  const version = environment.translationVersion
  return new TranslateHttpLoader(
    http,
    './assets/i18n/',
    `.json?v=${version}`
  )
}

export function appInitializerFactory(translate: TranslateService) {
  return () =>
    new Promise<void>((resolve) => {
      translate.setDefaultLang('fr')
      translate.use('fr').subscribe({
        next: () => resolve(),
        error: () => resolve()
      })
    })
}

@NgModule({
  declarations: [
    // Layouts.
    LayoutEmptyComponent,
    LayoutHomeComponent,
    LayoutMoodsComponent,
    LayoutToolsComponent,
    LayoutAboutComponent,
    // Pipes.
    FormatDurationPipe,
    FormatSizePipe,
    FormatRatioPipe,
    LocalizedDatePipe,
    // Directives.
    AnimRandomDirective,
    AnimGrowDirective,
    AnimSpinDirective,
    AnimRotation360Directive,
    ScrollToTopDirective,
    ToggleMenuRightDirective,
    GoBackDirective,
    ScrollDirective,
    ToggleMoodInfoDirective,
    ToggleMoodSizeDirective,
    ToggleDialogDirective,
    // Pages.
    DashboardComponent,
    HomeComponent,
    AboutComponent,
    CentralGalleryComponent,
    EditMoodComponent,
    EditTagsComponent,
    EditModelsComponent,
    EditArtistsComponent,
    EditFranchisesComponent,
    EditLinksComponent,
    TagsComponent,
    MediaComponent,
    ScriptsComponent,
    ToolsComponent,
    LinksComponent,
    CreateMoodImageComponent,
    CreateMoodVideoComponent,
    MultiTagComponent,
    MultiTagArtistsComponent,
    MultiTagModelsComponent,
    MultiTagTagsComponent,
    NotFoundComponent,
    SettingsComponent,
    SignUpComponent,
    LogInComponent,
    LogInErrorComponent,
    UserRegisterComponent,
    // Components.
    AppComponent,
    CurrentTimeComponent,
    ButtonBackComponent,
    ButtonTopComponent,
    DialogComponent,
    RelatedTagsComponent,
    ColumnFullComponent,
    BottomBarComponent,
    DialogInfoComponent,
    RightColumnComponent,
    FooterComponent,
    OverlayComponent,
    GdprComponent,
    LeftColumnComponent,
    HeaderHomeComponent,
    HeaderMoodsComponent,
    LanguageMenuHeaderComponent,
    LanguageMenuHomeComponent,
    SpacerComponent,
    RightColumnGenericListComponent,
    // => Features :
    // Dashboard.
    StatusComponent,
    AchievementsComponent,
    DashboardEditionMenuComponent,
    AccountComponent,
    DashboardHeaderComponent,
    // Moods.
    EditMoodMenuComponent,
    EditMoodThumbnailComponent,
    EditMoodFormComponent,
    EditMoodScoreComponent,
    EditMoodTagsComponent,
    EditMoodArtistsComponent,
    EditMoodModelsComponent,
    GalleryComponent,
    MoodInformationsComponent,
    // Tags.
    CreateTagCategoryComponent,
    CreateTagComponent,
    EditTagCategoryComponent,
    EditTagComponent,
    DeleteTagCategoryComponent,
    DeleteTagComponent,
    // Models.
    CreateModelComponent,
    EditModelComponent,
    DeleteModelComponent,  
    RelatedFranchisesComponent,  
    // Artists.
    CreateArtistComponent,
    CreateStyleComponent,
    EditStyleComponent,
    EditArtistComponent,
    DeleteStyleComponent,
    DeleteArtistComponent,
    // Franchises.
    CreateMediumComponent,
    CreateFranchiseComponent,
    EditMediumComponent,
    EditFranchiseComponent,
    DeleteMediumComponent,
    DeleteFranchiseComponent,
    RelatedModelsComponent,
    // Links.
    CreateLinkCategoryComponent,
    CreateLinkComponent,
    EditLinkCategoryComponent,
    EditLinkComponent,
    DeleteLinkCategoryComponent,
    DeleteLinkComponent,
    // Scripts.
    IntroductionComponent,
    MusicArsenalComponent,
    NotesComponent,
    NotesTradComponent,
    PulsationComponent,
    KeyRefComponent,
    IntervalsComponent,
    ChordsComponent,
    ScalesComponent,
    NotationComponent,
    TimeSignatureComponent,
    RythmicArsenalComponent,
    MelodicArsenalComponent,
    HarmonicArsenalComponent,
    MusicPrinciplesComponent,
    TheOctaveComponent,
    PointOfViewComponent,
    TimbreComponent,
    TonesComponent,
    TimeValuesComponent,
    // Tools.
    ChordWheelComponent,
    CircleOfFifthsComponent,
    DiapasonComponent,
    FlyingKeysMiniComponent,
    TrainerNotesComponent,
    GuitarTunerComponent,
    TimelineComponent,
    MetronomeComponent,
    // SVG Icons.
    IconStarComponent,
    IconEditComponent,
    IconUserComponent,
    IconMoodComponent,
    IconStatisticsComponent,
    IconTagComponent,
    IconLinkComponent,
    IconDollarComponent,
    IconArtistComponent,
    IconModelComponent,
    IconCoinComponent,
    IconHomeComponent,
    IconScriptComponent,
    IconToolsComponent,
    IconMoodsComponent,
    IconMediaComponent,
    IconLogoutComponent,
    IconSettingsComponent,
    IconHamburgerComponent,
    IconArrowComponent,
    IconQuestionComponent,
    IconInfoComponent,
    IconPlayComponent,
    IconStopComponent,
    IconResetComponent,
    IconPlusComponent,
    IconListComponent,
    IconGoComponent,
    IconBackComponent,
    IconArrowShortComponent,
    IconOpenComponent,
    IconGoogleComponent,
    IconGoogleLensComponent,
    IconPlayShuffleComponent,
    IconSaveComponent,
    IconMenuRightComponent,
    // Tools Icons
    IconWheelComponent,
    IconDiapasonComponent,
    IconKeyboardComponent,
    IconTimelineComponent,
    IconMetronomeComponent,
    // Clef
    IconClefBassComponent,
    IconClefTrebleComponent,
    IconClefAltoComponent,
    // Logo
    LogoFacebookComponent,
    LogoInstagramComponent,
    LogoYoutubeComponent,
    LogoSoundcloudComponent,
    // Time Values    
    TimeValueSixteenthComponent,
    TimeValueWholeComponent,
    TimeValueHalfComponent,
    TimeValueQuarterComponent,
    TimeValueEighthComponent,
    TimeValueRestEighthComponent,
    TimeValueRestSixteenthComponent,
    TimeValueRestHalfComponent,
    TimeValueRestQuarterComponent,
    TimeValueRestWholeComponent,
    // Bottom Bar Icons
    BottomIconBackComponent,
    BottomIconToTopComponent,
    BottomIconSaveComponent,
    BottomToggleRightMenuComponent,
    BottomItemsLengthComponent,
    BottomItemNameComponent,
    BottomIconArtistComponent,
    BottomIconModelComponent,
    BottomIconTagComponent,
    BottomIconEditComponent,
    BottomIconMoodsComponent,
    BottomIconOpenComponent,
    BottomIconGoogleComponent,
    BottomIconGoogleImageComponent,
    BottomItemPositionComponent,
    BottomIconPageNextComponent,
    BottomIconPagePreviousComponent,
    BottomIconDiaporamaComponent,
    BottomIconShuffleComponent,
    BottomIconRandomMoodComponent,
    BottomIconDashboardEditionComponent,
    BottomIconDashboardStatusComponent,
    BottomIconDashboardAchievementsComponent,
    BottomIconDashboardAccountComponent,
    ChordWriterComponent,
    SongWriterComponent,
    SongWriterTestComponent,
    BottomToggleMoodSizeComponent,
    BottomToggleMoodInfoComponent,
    BottomToggleEntityInfoComponent,
    PrototypeComponent,
    CreateMoodVideoYoutubeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule, 
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right',
      timeOut: 2500,
      extendedTimeOut: 0,
      progressBar: true,
      closeButton: true,
      preventDuplicates: false,
      tapToDismiss: true,
      newestOnTop: true,
      easeTime: 750,
      enableHtml: true
    }),
    CommonModule,
    RouterModule,
    ReactiveFormsModule,
    FormsModule,
    NgxPaginationModule,
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: HttpLoaderFactory,
        deps: [HttpClient]
      }
    }),
    DragDropModule
  ],
  providers: [
    { provide: APP_INITIALIZER, useFactory: appInitializerFactory, deps: [TranslateService], multi: true },
    [CookieService],           
    { provide: HTTP_INTERCEPTORS, useClass: TokenInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }