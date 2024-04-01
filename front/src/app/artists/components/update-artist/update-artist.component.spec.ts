import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateArtistComponent } from './update-artist.component';

describe('UpdateArtistComponent', () => {
  let component: UpdateArtistComponent;
  let fixture: ComponentFixture<UpdateArtistComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UpdateArtistComponent]
    });
    fixture = TestBed.createComponent(UpdateArtistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
