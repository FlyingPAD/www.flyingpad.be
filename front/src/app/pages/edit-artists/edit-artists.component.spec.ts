import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditArtistsComponent } from './edit-artists.component';

describe('EditArtistsComponent', () => {
  let component: EditArtistsComponent;
  let fixture: ComponentFixture<EditArtistsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditArtistsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditArtistsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
