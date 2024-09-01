import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditionArtistsComponent } from './edition-artists.component';

describe('EditionArtistsComponent', () => {
  let component: EditionArtistsComponent;
  let fixture: ComponentFixture<EditionArtistsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditionArtistsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditionArtistsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
