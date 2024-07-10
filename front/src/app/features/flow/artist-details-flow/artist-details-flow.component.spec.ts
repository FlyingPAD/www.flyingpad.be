import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ArtistDetailsFlowComponent } from './artist-details-flow.component';

describe('ArtistDetailsFlowComponent', () => {
  let component: ArtistDetailsFlowComponent;
  let fixture: ComponentFixture<ArtistDetailsFlowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ArtistDetailsFlowComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ArtistDetailsFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
