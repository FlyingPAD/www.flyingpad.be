import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LearnMusicComponent } from './learn-music.component';

describe('LearnMusicComponent', () => {
  let component: LearnMusicComponent;
  let fixture: ComponentFixture<LearnMusicComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LearnMusicComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LearnMusicComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
