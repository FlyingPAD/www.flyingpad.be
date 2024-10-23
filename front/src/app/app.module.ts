import { HTTP_INTERCEPTORS, HttpClient, HttpClientModule } from '@angular/common/http';
import { TokenInterceptor } from './interceptors/token.interceptor';

import { NgModule } from '@angular/core'
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CookieService } from 'ngx-cookie-service';
import { ToastrModule } from 'ngx-toastr';
import { ErrorInterceptor } from './interceptors/error.interceptor';
import { FlowComponent } from './pages/flow/flow.component';
import { AboutComponent } from './pages/about/about.component';
import { HomeComponent } from './pages/home/home.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { UserLoginErrorComponent } from './pages/user-login-error/user-login-error.component';
import { UserRegisterComponent } from './pages/user-register/user-register.component';
import { LayoutEmptyComponent } from './layouts/layout-empty/layout-empty.component';
import { LayoutCustomComponent } from './layouts/layout-custom/layout-custom.component';
import { UserUpdateComponent } from './pages/user-update/user-update.component';
import { UserDetailsComponent } from './pages/user-details/user-details.component';
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
import { MoodDetailsFlowComponent } from './features/flow/mood-details-flow/mood-details-flow.component';
import { MoodsGalleryFlowComponent } from './features/flow/moods-gallery-flow/moods-gallery-flow.component';
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
import { MediasComponent } from './pages/medias/medias.component';
import { LinksComponent } from './pages/links/links.component';
import { RightColumnListComponent } from './components/right-column-list/right-column-list.component';
import { ListCentralComponent } from './components/list-central/list-central.component';
import { ModelDetailsFlowComponent } from './features/flow/model-details-flow/model-details-flow.component';
import { ArtistDetailsFlowComponent } from './features/flow/artist-details-flow/artist-details-flow.component';
import { TagDetailsFlowComponent } from './features/flow/tag-details-flow/tag-details-flow.component';
import { FranchiseDetailsFlowComponent } from './features/flow/franchise-details-flow/franchise-details-flow.component';
import { LinkCategoryDetailsFlowComponent } from './features/flow/link-category-details-flow/link-category-details-flow.component';
import { LinkDetailsFlowComponent } from './features/flow/link-details-flow/link-details-flow.component';
import { MediaDetailsFlowComponent } from './features/flow/media-details-flow/media-details-flow.component';
import { StyleDetailsFlowComponent } from './features/flow/style-details-flow/style-details-flow.component';
import { TagCategoryDetailsFlowComponent } from './features/flow/tag-category-details-flow/tag-category-details-flow.component';
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
import { TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { HiddenMenuWithFooterComponent } from './layouts/hidden-menu-with-footer/hidden-menu-with-footer.component';
import { MenuHiddenComponent } from './components/menu-hidden/menu-hidden.component';
import { HeaderComponent } from './components/header/header.component';
import { OverlayComponent } from './components/overlay/overlay.component';
import { MediumGalleryComponent } from './pages/medium-gallery/medium-gallery.component';
import { MyAccountComponent } from './pages/my-account/my-account.component';
import { SettingsComponent } from './pages/settings/settings.component';
import { FormatRatioPipe } from './pipes/format-ratio.pipe';
import { TimelineComponent } from './features/scripts/timeline/timeline.component';
import { LocalizedDatePipe } from './pipes/localized-date.pipe';
import { GuitarTunerComponent } from './features/tools/guitar-tuner/guitar-tuner.component';
import { ChordWheelComponent } from './features/tools/chord-wheel/chord-wheel.component';
import { BottomBarLargerComponent } from './components/bottom-bar-larger/bottom-bar-larger.component';
import { GdprComponent } from './components/gdpr/gdpr.component';
import { StandardLayoutComponent } from './layouts/standard-layout/standard-layout.component';
import { LeftColumnComponent } from './components/left-column/left-column.component';

export function HttpLoaderFactory(http: HttpClient) {
  return new TranslateHttpLoader(http, './assets/i18n/', '.json');
}

@NgModule({
  declarations: [
    // Layouts.
    LayoutEmptyComponent,
    LayoutCustomComponent,
    HiddenMenuWithFooterComponent,
    // Pipes.
    FormatDurationPipe,
    FormatSizePipe,
    FormatRatioPipe,
    LocalizedDatePipe,
    // Directives.
    AnimRandomDirective,
    AnimGrowDirective,
    AnimSpinDirective,
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
    MediasComponent,
    MediumGalleryComponent,
    ScriptsComponent,
    ToolsComponent,
    FlowComponent,
    LinksComponent,
    NotFoundComponent,
    MyAccountComponent,
    SettingsComponent,
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
    MenuHiddenComponent,
    HeaderComponent,
    FooterComponent,
    OverlayComponent,
    // => Features :
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
    UserDetailsComponent,
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
    // Tools.
    ChordWheelComponent,
    CircleOfFifthsComponent,
    DiapasonComponent,
    FlyingKeysMiniComponent,
    TrainerNotesComponent,
    GuitarTunerComponent,
    // => Flow.
    MoodsGalleryFlowComponent,
    MoodDetailsFlowComponent,
    TagCategoryDetailsFlowComponent,
    TagDetailsFlowComponent,
    StyleDetailsFlowComponent,
    ArtistDetailsFlowComponent,
    ModelDetailsFlowComponent,
    MediaDetailsFlowComponent,
    FranchiseDetailsFlowComponent,
    LinkCategoryDetailsFlowComponent,
    LinkDetailsFlowComponent,
    GdprComponent,
    StandardLayoutComponent,
    LeftColumnComponent
  ],
  imports: [
    // --- CORE :
    BrowserModule,
    AppRoutingModule,

    // --- NATIVE :
    HttpClientModule,                       // Manual Import
    BrowserAnimationsModule,                // Enables Animations ( Required for Toastr )

    // Toastr Configuration :    
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right',  // Position des notifications toastr
      timeOut: 1500,                        // Désactive l'autodismiss (0 = infini)
      extendedTimeOut: 0,                   // Désactive le timeout au survol (hover)
      progressBar: true,                    // Affiche une barre de progression
      closeButton: true,                    // Affiche un bouton de fermeture
      preventDuplicates: false,             // Autorise les duplications
      tapToDismiss: true,                   // Permet la fermeture en cliquant dessus
      newestOnTop: true,                    // Les nouveaux toasts apparaissent en haut
      easeTime: 750,                        // Désactive l'animation
      enableHtml: true                      // Autorise le contenu HTML
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
    [CookieService],           
    { provide: HTTP_INTERCEPTORS, useClass: TokenInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }