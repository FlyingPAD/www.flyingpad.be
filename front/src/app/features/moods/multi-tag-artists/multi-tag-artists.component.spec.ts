import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MultiTagArtistsComponent } from './multi-tag-artists.component';

describe('MultiTagArtistsComponent', () => {
  let component: MultiTagArtistsComponent;
  let fixture: ComponentFixture<MultiTagArtistsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MultiTagArtistsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MultiTagArtistsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
