import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MusicPrinciplesComponent } from './music-principles.component';

describe('MusicPrinciplesComponent', () => {
  let component: MusicPrinciplesComponent;
  let fixture: ComponentFixture<MusicPrinciplesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MusicPrinciplesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MusicPrinciplesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
