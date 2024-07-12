import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { TokenInterceptor } from './interceptor/token.interceptor';

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CookieService } from 'ngx-cookie-service';
import { ToastrModule } from 'ngx-toastr';
import { ErrorInterceptor } from './interceptor/error.interceptor';
import { FlowComponent } from './pages/flow/flow.component';
import { AboutComponent } from './pages/about/about.component';
import { HomeComponent } from './pages/home/home.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { UserLoginErrorComponent } from './pages/user-login-error/user-login-error.component';
import { UserRegisterComponent } from './pages/user-register/user-register.component';
import { LayoutEmptyComponent } from './layouts/layout-empty/layout-empty.component';
import { LayoutCustomComponent } from './layouts/layout-custom/layout-custom.component';
import { EditionComponent } from './features/models/edition/edition.component';
import { UserUpdateComponent } from './pages/user-update/user-update.component';
import { UserDetailsComponent } from './pages/user-details/user-details.component';
import { ChordWheelSvgComponent } from './features/tools/chord-wheel-svg/chord-wheel-svg.component';
import { CircleOfFifthsComponent } from './features/tools/circle-of-fifths/circle-of-fifths.component';
import { DiapasonComponent } from './features/tools/diapason/diapason.component';
import { FlyingKeysMiniComponent } from './features/tools/flying-keys-mini/flying-keys-mini.component';
import { TrainerNotesComponent } from './features/tools/trainer-notes/trainer-notes.component';
import { TagsEditionComponent } from './features/tags/tags-edition/tags-edition.component';
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
import { MoodEditionComponent } from './features/moods/mood-edition/mood-edition.component';
import { MoodsGalleryComponent } from './features/moods/moods-gallery/moods-gallery.component';
import { MoodsMultiTagComponent } from './features/moods/moods-multi-tag/moods-multi-tag.component';
import { MultiTagArtistsComponent } from './features/moods/multi-tag-artists/multi-tag-artists.component';
import { MultiTagModelsComponent } from './features/moods/multi-tag-models/multi-tag-models.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { FranchisesEditionComponent } from './features/franchises/franchises-edition/franchises-edition.component';
import { MediaGalleryComponent } from './features/franchises/media-gallery/media-gallery.component';
import { ArtistsListComponent } from './features/artists/artists-list/artists-list.component';
import { CreateArtistComponent } from './features/artists/create-artist/create-artist.component';
import { CreateStyleComponent } from './features/artists/create-style/create-style.component';
import { DeleteArtistComponent } from './features/artists/delete-artist/delete-artist.component';
import { DeleteStyleComponent } from './features/artists/delete-style/delete-style.component';
import { UpdateArtistComponent } from './features/artists/update-artist/update-artist.component';
import { UpdateStyleComponent } from './features/artists/update-style/update-style.component';
import { LayoutArtistsComponent } from './layouts/layout-artists/layout-artists.component';
import { LinksEditionComponent } from './features/links/links-edition/links-edition.component';
import { LinksGalleryComponent } from './features/links/links-gallery/links-gallery.component';
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
import { LeftCardComponent } from './components/left-card/left-card.component';
import { ModelDetailsFlowComponent } from './features/flow/model-details-flow/model-details-flow.component';

@NgModule({
  declarations: 
  [
    // Pages.
    HomeComponent,
    DashboardComponent,
    AboutComponent,
    MoodsComponent,
    TagsComponent,
    MediasComponent,
    ScriptsComponent,
    ToolsComponent,
    FlowComponent,
    LinksComponent,
    NotFoundComponent,
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
    DialogInfoComponent,
    RightColumnComponent,
    RightColumnListComponent,
    ListCentralComponent,
    LeftCardComponent,
    // => Franchises
    MediaGalleryComponent,
    FranchisesEditionComponent,
    FranchisesEditionComponent,
    // => Artists
    LayoutArtistsComponent,
    ArtistsListComponent,
    CreateArtistComponent,
    CreateStyleComponent,
    UpdateArtistComponent,
    UpdateStyleComponent,
    DeleteArtistComponent,
    DeleteStyleComponent,
    // => Layouts
    LayoutEmptyComponent,
    LayoutCustomComponent,
    LayoutArtistsComponent,
    // => Moods
    MoodDetailsComponent,
    MoodsGalleryComponent,
    MoodEditionComponent,
    CreateMoodImageComponent,
    CreateMoodVideoComponent,
    MoodsMultiTagComponent,
    MultiTagArtistsComponent,
    MultiTagModelsComponent,
    MoodDetailsFlowComponent,
    MoodsGalleryFlowComponent,
    MoodViewerComponent,
    // => Models
    EditionComponent,
    // => Tags
    TagsEditionComponent,
    // => Scripts
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
    // => Tools
    ChordWheelSvgComponent,
    CircleOfFifthsComponent,
    DiapasonComponent,
    FlyingKeysMiniComponent,
    TrainerNotesComponent,
    // => Users
    UserDetailsComponent,
    UserUpdateComponent,
    UserRegisterComponent,
    UserLoginErrorComponent,
    // => Links
    LinksEditionComponent,
    LinksGalleryComponent,
    // Pipes.
    FormatDurationPipe,
    FormatSizePipe,
    // Directives.
    AnimRandomDirective,
    AnimGrowDirective,
    AnimSpinDirective,
    ModelDetailsFlowComponent,
  ],
  imports: 
  [
    // --- CORE :
    BrowserModule,
    AppRoutingModule,

    // --- NATIVE :
    HttpClientModule,                       // Manual Import
    BrowserAnimationsModule,                // Enables Animations ( Required for Toastr )

    // Toastr Configuration :    
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right',  // Position of the toastr notifications on the screen
      timeOut: 3000,                        // Duration in milliseconds for which toastr will be displayed (3 seconds)
      progressBar: true,                    // Whether to show a progress bar indicating time remaining
      closeButton: true,                    // Whether to display a close button on the toastr
      preventDuplicates: true,              // Whether to prevent duplicate toastr from appearing
      tapToDismiss: true,                   // Whether to allow dismissing toastr by clicking on it
      newestOnTop: true,                    // Whether new toastr should appear on top of the older ones
      easeTime: 500,                        // Duration of slide-in/out animation in milliseconds
      enableHtml: true                      // Whether HTML content is allowed in toastr messages
    }),
    CommonModule,
    RouterModule,
    ReactiveFormsModule,
    FormsModule,
    NgxPaginationModule,
  ],
  providers: 
  [
    [CookieService],              
    { provide: HTTP_INTERCEPTORS, useClass: TokenInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }