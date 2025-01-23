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
import { UserLoginErrorComponent } from './pages/user-login-error/user-login-error.component';
import { UserRegisterComponent } from './pages/user-register/user-register.component';
import { LayoutEmptyComponent } from './layouts/layout-empty/layout-empty.component';
import { UserUpdateComponent } from './pages/user-update/user-update.component';
import { CircleOfFifthsComponent } from './features/tools/circle-of-fifths/circle-of-fifths.component';
import { DiapasonComponent } from './features/tools/diapason/diapason.component';
import { FlyingKeysMiniComponent } from './features/tools/flying-keys-mini/flying-keys-mini.component';
import { TrainerNotesComponent } from './features/tools/trainer-notes/trainer-notes.component';
import { ChordsComponent } from './features/scripts/chords/chords.component';
import { IntervalsComponent } from './features/scripts/intervals/intervals.component';
import { IntroComponent } from './features/scripts/intro/intro.component';
import { KeyRefComponent } from './features/scripts/key-ref/key-ref.component';
import { LearnMusicComponent } from './features/scripts/learn-music/learn-music.component';
import { MelodyComponent } from './features/scripts/melody/melody.component';
import { MetricsAComponent } from './features/scripts/metrics-a/metrics-a.component';
import { MetricsBComponent } from './features/scripts/metrics-b/metrics-b.component';
import { NotationComponent } from './features/scripts/notation/notation.component';
import { NotesExComponent } from './features/scripts/notes-ex/notes-ex.component';
import { NotesTradComponent } from './features/scripts/notes-trad/notes-trad.component';
import { NotesComponent } from './features/scripts/notes/notes.component';
import { PulsationComponent } from './features/scripts/pulsation/pulsation.component';
import { ScalesComponent } from './features/scripts/scales/scales.component';
import { ViewpointComponent } from './features/scripts/viewpoint/viewpoint.component';
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
import { CreateMoodImageComponent } from './features/moods/create-mood-image/create-mood-image.component';
import { CreateMoodVideoComponent } from './features/moods/create-mood-video/create-mood-video.component';
import { MoodsGalleryComponent } from './features/moods/moods-gallery/moods-gallery.component';
import { MultiTagArtistsComponent } from './features/moods/multi-tag-artists/multi-tag-artists.component';
import { MultiTagModelsComponent } from './features/moods/multi-tag-models/multi-tag-models.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { CreateArtistComponent } from './features/artists/create-artist/create-artist.component';
import { MoodDetailsComponent } from './features/moods/mood-details/mood-details.component';
import { ListFlowComponent } from './components/list-flow/list-flow.component';
import { TagsComponent } from './pages/tags/tags.component';
import { ScriptsComponent } from './pages/scripts/scripts.component';
import { ToolsComponent } from './pages/tools/tools.component';
import { MoodsComponent } from './pages/moods/moods.component';
import { RelatedTagsComponent } from './features/tags/related-tags/related-tags.component';
import { ColumnFullComponent } from './features/tags/column-full/column-full.component';
import { BottomBarComponent } from './components/bottom-bar/bottom-bar.component';
import { DialogInfoComponent } from './components/dialog-info/dialog-info.component';
import { RightColumnComponent } from './components/right-column/right-column.component';
import { MoodViewerComponent } from './features/moods/mood-viewer/mood-viewer.component';
import { MediaComponent } from './pages/media/media.component';
import { LinksComponent } from './pages/links/links.component';
import { RightColumnListComponent } from './components/right-column-list/right-column-list.component';
import { ListCentralComponent } from './components/list-central/list-central.component';
import { EditionMenuComponent } from './features/moods/edition-menu/edition-menu.component';
import { EditionTagsComponent } from './features/moods/edition-tags/edition-tags.component';
import { EditionArtistsComponent } from './features/moods/edition-artists/edition-artists.component';
import { EditionModelsComponent } from './features/moods/edition-models/edition-models.component';
import { EditionInfoComponent } from './features/moods/edition-info/edition-info.component';
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
import { MultiTagComponent } from './features/moods/multi-tag/multi-tag.component';
import { FooterComponent } from './components/footer/footer.component';
import { TranslateLoader, TranslateModule, TranslateService } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { OverlayComponent } from './components/overlay/overlay.component';
import { MediumGalleryComponent } from './pages/medium-gallery/medium-gallery.component';
import { SettingsComponent } from './pages/settings/settings.component';
import { FormatRatioPipe } from './pipes/format-ratio.pipe';
import { TimelineComponent } from './features/scripts/timeline/timeline.component';
import { LocalizedDatePipe } from './pipes/localized-date.pipe';
import { GuitarTunerComponent } from './features/tools/guitar-tuner/guitar-tuner.component';
import { ChordWheelComponent } from './features/tools/chord-wheel/chord-wheel.component';
import { BottomBarLargerComponent } from './components/bottom-bar-larger/bottom-bar-larger.component';
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
import { StatisticsComponent } from './features/dashboard/statistics/statistics.component';
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
import { DashboardMenuComponent } from './features/dashboard/dashboard-menu/dashboard-menu.component';
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

export function HttpLoaderFactory(http: HttpClient) {
  let version : string = '1.0.0'
  return new TranslateHttpLoader(http, './assets/i18n/', `.json?v=${version}`)
}

export function appInitializerFactory(translate: TranslateService) {
  return () => new Promise<void>((resolve) => {
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
    // Pages.
    DashboardComponent,
    HomeComponent,
    AboutComponent,
    EditTagsComponent,
    EditModelsComponent,
    EditArtistsComponent,
    EditFranchisesComponent,
    EditLinksComponent,
    MoodsComponent,
    TagsComponent,
    MediaComponent,
    MediumGalleryComponent,
    ScriptsComponent,
    ToolsComponent,
    LinksComponent,
    NotFoundComponent,
    SettingsComponent,
    SignUpComponent,
    LogInComponent,
    // Components.
    AppComponent,
    ListFlowComponent,
    CurrentTimeComponent,
    ButtonBackComponent,
    ButtonTopComponent,
    DialogComponent,
    RelatedTagsComponent,
    ColumnFullComponent,
    BottomBarComponent,
    BottomBarLargerComponent,
    DialogInfoComponent,
    RightColumnComponent,
    RightColumnListComponent,
    ListCentralComponent,
    FooterComponent,
    OverlayComponent,
    GdprComponent,
    LeftColumnComponent,
    HeaderHomeComponent,
    HeaderMoodsComponent,
    LanguageMenuHeaderComponent,
    LanguageMenuHomeComponent,
    // => Features :
    // Dashboard.
    StatisticsComponent,
    StatusComponent,
    AchievementsComponent,
    DashboardEditionMenuComponent,
    AccountComponent,
    DashboardMenuComponent,
    DashboardHeaderComponent,
    // Moods.
    CreateMoodImageComponent,
    CreateMoodVideoComponent,
    MoodsGalleryComponent,
    MoodDetailsComponent,
    EditionMenuComponent,
    EditionInfoComponent,
    MoodViewerComponent,
    MultiTagArtistsComponent,
    MultiTagModelsComponent,
    MultiTagComponent,
    // Tags.
    CreateTagCategoryComponent,
    CreateTagComponent,
    EditTagCategoryComponent,
    EditTagComponent,
    DeleteTagCategoryComponent,
    DeleteTagComponent,
    EditionTagsComponent,
    // Models.
    CreateModelComponent,
    EditModelComponent,
    DeleteModelComponent,    
    EditionModelsComponent,
    // Artists.
    CreateArtistComponent,
    CreateStyleComponent,
    EditStyleComponent,
    EditArtistComponent,
    DeleteStyleComponent,
    DeleteArtistComponent,
    EditionArtistsComponent,
    // Franchises.
    CreateMediumComponent,
    CreateFranchiseComponent,
    EditMediumComponent,
    EditFranchiseComponent,
    DeleteMediumComponent,
    DeleteFranchiseComponent,
    // Links.
    CreateLinkCategoryComponent,
    CreateLinkComponent,
    EditLinkCategoryComponent,
    EditLinkComponent,
    DeleteLinkCategoryComponent,
    DeleteLinkComponent,
    // Users.
    UserUpdateComponent,
    UserRegisterComponent,
    UserLoginErrorComponent,
    // Scripts.
    NotesComponent,
    NotesTradComponent,
    PulsationComponent,
    MetricsAComponent,
    IntroComponent,
    KeyRefComponent,
    IntervalsComponent,
    ChordsComponent,
    ScalesComponent,
    NotationComponent,
    MelodyComponent,
    MetricsBComponent,
    NotesExComponent,
    LearnMusicComponent,
    ViewpointComponent,
    TimelineComponent,
    MusicPrinciplesComponent,
    // Tools.
    ChordWheelComponent,
    CircleOfFifthsComponent,
    DiapasonComponent,
    FlyingKeysMiniComponent,
    TrainerNotesComponent,
    GuitarTunerComponent,
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
    IconWheelComponent,
    IconOpenComponent,
    IconGoogleComponent,
    IconGoogleLensComponent,
    IconPlayShuffleComponent,
    LogoFacebookComponent,
    LogoInstagramComponent,
    LogoYoutubeComponent,
    LogoSoundcloudComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule, 
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right',
      timeOut: 1500,
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
    })
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