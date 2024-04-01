import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteArtistComponent } from './delete-artist.component';

describe('DeleteArtistComponent', () => {
  let component: DeleteArtistComponent;
  let fixture: ComponentFixture<DeleteArtistComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeleteArtistComponent]
    });
    fixture = TestBed.createComponent(DeleteArtistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
